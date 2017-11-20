

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.SeeBestAdvertisementBP.ARBillRelationBP.Proxy;
using UFSoft.UBF.Util.DataAccess;

#endregion

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE
{

    public partial class AdvApproveBE
    {

        public override Base.Doc.DocType DocType
        {
            get { return this.AdvApproveDocType; }
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
            if (this.StateMachineInstance.CurrentState == AdvApproveBEStateMachine.State.Empty)
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
            //单号赋默认值 -- 客户简称+YYMM+2流水号
            string strCustomerAbbreviation = "";
            if (this.AdvApplyCust != null)
            {
                if (string.IsNullOrEmpty(this.AdvApplyCust.DescFlexField.PrivateDescSeg11))
                {
                    strCustomerAbbreviation = "";
                }
                else
                {
                    strCustomerAbbreviation = this.AdvApplyCust.DescFlexField.PrivateDescSeg11;
                }
            }

            string strNo = strCustomerAbbreviation + System.DateTime.Now.ToString("yyMM") + "%";
            string strRunningCode = "";

            DataParamList lst1 = new DataParamList();
            lst1.Add(DataParamFactory.CreateInput("@strNo", strNo, System.Data.DbType.String));
            System.Data.DataSet ds1 = new System.Data.DataSet();

            DataAccessor.RunSQL(DataAccessor.GetConn(), "select top 1 case when convert(int,substring(DocNo,len(DocNo)-1,2))=99 then '01' else right('00'+convert(varchar(2),(convert(int,substring(DocNo,len(DocNo)-1,2))+1)),2) end as Flow2Bit from Cust_SeeBest_AdvApprove where DocNo like @strNo order by CreatedOn desc", lst1, out ds1);

            if (ds1 != null && ds1.Tables.Count > 0)
            {
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(ds1.Tables[0].Rows[0]["Flow2Bit"].ToString()) > 0)
                    {
                        strRunningCode = ds1.Tables[0].Rows[0]["Flow2Bit"].ToString();
                    }
                }
                else
                {
                    strRunningCode = "01";
                }
            }

            this.DocNo = strCustomerAbbreviation + System.DateTime.Now.ToString("yyMM") + strRunningCode;
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
        }

        /// <summary>
        /// after Update
        /// </summary>
        protected override void OnUpdated()
        {
            base.OnUpdated();
            //if (this.DocStatus == AdvAppStatusEnum.Approved && string.IsNullOrEmpty(this.DescFlexField.PrivateDescSeg1))
            //{
            //    ARBillImportBPProxy proxy = new ARBillImportBPProxy();
            //    proxy.RelationId = this.ID;
            //    var data = proxy.Do();
            //}
        }


        /// <summary>
        /// before Delete
        /// </summary>
        protected override void OnDeleting()
        {
            base.OnDeleting();
            // TO DO: write your business code here...
            //if (!string.IsNullOrEmpty(this.DescFlexField.PrivateDescSeg1))
            //{
            //    throw new Exception("已经生成了应收单");
            //}
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
        private static AdvApproveBE CreateDefault_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create DefaultComponent
        /// </summary>
        /// <returns>DefaultComponent Instance</returns>
        private static AdvApproveBE CreateDefaultComponent_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }

        #endregion






        #region Model Methods
        #endregion
    }
}
