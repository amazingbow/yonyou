

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Base.UserRole;
using UFIDA.U9.CBO.SCM.Customer;
using UFSoft.UBF.Sys.Database;
using UFSoft.UBF.Util.DataAccess;

#endregion

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE
{

    public partial class AdvApplyBE
    {
        public override Base.Doc.DocType DocType
        {
            get { return this.AdvApplyDocType; }
        }

        #region Custom Constructor

        #endregion

        #region before & after CUD V
        /*	实体提交的事件顺序示例(QHELP) 主实体A 组合 非主实体B .
		/ (新增A和B两个实例)A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnInserting ->B.OnInserting ->产生提交SQL ->B.OnInserted ->A.OnInserted
		/ (仅修改B,A也会被修改))A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnUpdating ->B.OnUpdating ->产生提交SQL ->B.OnUpdated ->A.OnUpdated
		/ (删除A,B会被级联删除))A.OnDeleting ->B.OnDeleting ->产生提交SQL ->B.OnDeleted ->A.OnDeleted
		/	产生提交SQL顺序则看其外键，增修一对多先A后B，一对一先B后A。　删除一对多先B后A，一对一先A后B .
		*/
        /// <summary>
        /// 设置默认值
        /// </summary>
        protected override void OnSetDefaultValue()
        {
            base.OnSetDefaultValue();
            if (this.Org == null)
            {
                this.Org = Context.LoginOrg;
            }
            if (this.StateMachineInstance.CurrentState == AdvApplyBEStateMachine.State.Empty)
            {
                this.StateMachineInstance.Initialize();
            }
        }
        /// <summary>
        /// before Insert
        /// </summary>
        protected override void OnInserting()
        {
            base.OnInserting();
            // 自动生成编码（编号规则：闽厦+4位流水码（初始码0100）+事业部简码（L/Q...)+下单日期（YYMMDD）
            #region 获取4位码
            this.Flow4Bit = 100;
            int intYear;
            if (this.ApplyDate == null || this.ApplyDate == System.DateTime.MinValue)
            {
                intYear = System.DateTime.Now.Year;
            }
            else
            {
                intYear = this.ApplyDate.Year;
            }
            string sql = "select top 1 Flow4Bit  from Cust_SeeBest_AdvApply where ApplyDept=" + this.ApplyDept.ID + " and year(ApplyDate)=" + intYear + " order by Flow4Bit desc ";
            DataSet data = new DataSet();
            DataAccessor.RunSQL(DataAccessor.GetConn(), sql, null, out data);
            if (data.Tables.Count > 0)
            {
                if (data.Tables[0].Rows.Count > 0)
                {
                    var lastFlow4Bit = int.Parse(data.Tables[0].Rows[0]["Flow4Bit"].ToString());
                    this.Flow4Bit = lastFlow4Bit + 1;
                    if (this.Flow4Bit > 9999)
                    {
                        this.Flow4Bit = 100;
                    }
                    DateTime dtFirstDay = new DateTime(DateTime.Now.Year, 1, 1);
                    if (this.ApplyDate == dtFirstDay)
                    {
                        this.Flow4Bit = 100;
                    }
                }
            }
            #endregion
            string temp = string.Empty;
            foreach (var item in this.AdvAboutBE)
            {
                temp += item.Code + "/";
            }
            temp = temp.TrimEnd('/');

            this.AdvCode = this.ApplyDept.DescFlexField.PrivateDescSeg11 + this.Flow4Bit.ToString().PadLeft(4, '0') + temp + DateTime.Now.ToString("yyMMdd");

        }

        /// <summary>
        /// after Insert
        /// </summary>
        protected override void OnInserted()
        {
            base.OnInserted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// before Update
        /// </summary>
        protected override void OnUpdating()
        {
            base.OnUpdating();
            // TO DO: write your business code here...
            //当广告体现项目变更，编号跟着变更
            if (string.IsNullOrEmpty(this.AdvCode))
            {

            }
            else
            {
                int AdvCodeLength = 0;
                AdvCodeLength = this.AdvCode.Length;
                int a = 0;
                if (string.IsNullOrEmpty(this.ApplyDept.DescFlexField.PrivateDescSeg11))
                {
                    a = 0;
                }
                else
                {
                    a = this.ApplyDept.DescFlexField.PrivateDescSeg11.Length;
                }
                int b = 0;
                b = AdvCodeLength - (a + 4) - 6;
                string strBefore = "";
                strBefore = this.AdvCode.Substring(0, a + 4);
                string strAfter = "";
                strAfter = this.AdvCode.Substring(a + 4 + b, 6);
                string temp = string.Empty;
                foreach (var item in this.AdvAboutBE)
                {
                    temp += item.Code + "/";
                }
                temp = temp.TrimEnd('/');

                this.AdvCode = strBefore + temp + strAfter;
            }
        }

        /// <summary>
        /// after Update
        /// </summary>
        protected override void OnUpdated()
        {
            base.OnUpdated();
            // TO DO: write your business code here...
        }


        /// <summary>
        /// before Delete
        /// </summary>
        protected override void OnDeleting()
        {
            base.OnDeleting();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// after Delete
        /// </summary>
        protected override void OnDeleted()
        {
            base.OnDeleted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// on Validate
        /// </summary>
        protected override void OnValidate()
        {
            base.OnValidate();
            this.SelfEntityValidator();
            // TO DO: write your business code here...
            //if (this.AdvAboutBE.Count == 0)
            //{
            //    throw new Exception("广告体现项目不能为空！");
            //}
            if (this.Qty <= 0 || this.BMWidth <= 0 || this.BMHight <= 0)
            {
                throw new Exception("数量、版面-宽、版面-高，都必须大于0！");
            }
        }
        #endregion

        #region 异常处理，开发人员可以重新封装异常
        public override void DealException(Exception e)
        {
            base.DealException(e);
            throw e;
        }
        #endregion

        #region  扩展属性代码区

        #endregion

        #region CreateDefault
        private static AdvApplyBE CreateDefault_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create DefaultComponent
        /// </summary>
        /// <returns>DefaultComponent Instance</returns>
        private static AdvApplyBE CreateDefaultComponent_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }

        #endregion






        #region Model Methods
        #endregion
    }
}
