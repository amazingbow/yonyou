

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.DataAccess;

#endregion

namespace UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE {

	public partial class SpecialApplyBE{

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
		}
		/// <summary>
		/// before Insert
		/// </summary>
		protected override void OnInserting() {
			base.OnInserting();
            // TO DO: write your business code here...
            #region 编码规则赋默认值："ZG"+事业部简码+下单日期+流水码（4位）

            //事业部简码：由产品类型决定，产品类型与事业部简码对应；如果选定的产品类型涉及多个事业部，则事业部简码通过“/”连接起来；
            string strDivisionCode = "";//事业部简码
            if (this.SpecialSizeBE.Count > 0)
            {
                for (int i = 0; i < this.SpecialSizeBE.Count; i++)
                {
                    if (strDivisionCode.Contains(this.SpecialSizeBE[i].DisplayProductType.Description))
                    {

                    }
                    else
                    {
                        if (i == (this.SpecialSizeBE.Count - 1))
                        {
                            strDivisionCode = strDivisionCode + this.SpecialSizeBE[i].DisplayProductType.Description;
                        }
                        else
                        {
                            strDivisionCode = strDivisionCode + this.SpecialSizeBE[i].DisplayProductType.Description + "/";
                        }
                    }
                }
                if (strDivisionCode.Substring(strDivisionCode.Length - 1, 1) == "/")
                {
                    strDivisionCode = strDivisionCode.Substring(0, strDivisionCode.Length - 1);
                }
                strDivisionCode = "(" + strDivisionCode + ")";
            }

            //下单日期
            string strApplyDate = "";//下单日期
            if (this.ApplyDate == null || this.ApplyDate == System.DateTime.MinValue)
            {
                strApplyDate = System.DateTime.Now.ToString("yyyyMMdd");
            }
            else
            {
                strApplyDate = this.ApplyDate.ToString("yyyyMMdd");
            }

            //流水码（4位）：流水码从0001开始，所有办事处每年都从0001开始，每年依据下单日期的年份；
            string strRunningCode = "";//流水码
            int intYear;
            if (this.ApplyDate == null || this.ApplyDate == System.DateTime.MinValue)
            {
                intYear = System.DateTime.Now.Year;
            }
            else
            {
                intYear = this.ApplyDate.Year;
            }

            DataParamList lst1 = new DataParamList();
            lst1.Add(DataParamFactory.CreateInput("@intYear", intYear, System.Data.DbType.Int32));
            System.Data.DataSet ds1 = new System.Data.DataSet();

            DataAccessor.RunSQL(DataAccessor.GetConn(), "select top 1 case when convert(int,substring(AdvCode,len(AdvCode)-3,4))=9999 then '0001' else right('0000'+convert(varchar(4),(convert(int,substring(AdvCode,len(AdvCode)-3,4))+1)),4) end as Flow4Bit from Cust_SeeBest_SpecialApply where year(ApplyDate)=@intYear order by substring(AdvCode,len(AdvCode)-3,4) desc", lst1, out ds1);

            if (ds1 != null && ds1.Tables.Count > 0)
            {
                if (ds1.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(ds1.Tables[0].Rows[0]["Flow4Bit"].ToString()) > 0)
                    {
                        strRunningCode = ds1.Tables[0].Rows[0]["Flow4Bit"].ToString();
                    }
                }
                else
                {
                    strRunningCode = "0001";
                }
            }

            //编码规则："ZG"+事业部简码+下单日期+流水码（4位）
            this.AdvCode = "ZG" + strDivisionCode + strApplyDate + strRunningCode;

            #endregion
        }

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
			base.OnInserted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
			base.OnUpdated();
			// TO DO: write your business code here...
		}


		/// <summary>
		/// before Delete
		/// </summary>
		protected override void OnDeleting() {
			base.OnDeleting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Delete
		/// </summary>
		protected override void OnDeleted() {
			base.OnDeleted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
			base.OnValidate();
			this.SelfEntityValidator();
			// TO DO: write your business code here...
            if (this.SpecialSizeBE.Count == 0)
            {
                throw new Exception("专柜子制作详情不能为空！");
            }
		}
		#endregion
		
		#region 异常处理，开发人员可以重新封装异常
		public override void  DealException(Exception e)
        	{
          		base.DealException(e);
          		throw e;
        	}
		#endregion

		#region  扩展属性代码区
		
		#endregion

		#region CreateDefault
		private static SpecialApplyBE CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static SpecialApplyBE CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
