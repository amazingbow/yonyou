namespace UFIDA.U9.Cust.XMJLBomOpBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.DataAccess;

	/// <summary>
	/// GetBOMMainInfo partial 
	/// </summary>	
	public partial class GetBOMMainInfo 
	{	
		internal BaseStrategy Select()
		{
			return new GetBOMMainInfoImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetBOMMainInfoImpementStrategy : BaseStrategy
	{
		public GetBOMMainInfoImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetBOMMainInfo bpObj = (GetBOMMainInfo)obj;

            List<BOMMainInfoDto> BOMMainInfoDtolist = new List<BOMMainInfoDto>();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("1=1 and Status=1");
            //if (bpObj.ManufactureNo > 0L)
            //{
            //    sb.Append(" and ManufactureNo='" + bpObj.ManufactureNo + "'");
            //}
            //if (!string.IsNullOrEmpty(bpObj.ContractNo))
            //{
            //    sb.Append(" and ContractNo='" + bpObj.ContractNo + "'");
            //}
            //if (!string.IsNullOrEmpty(bpObj.CarType))
            //{
            //    sb.Append(" and CarType='" + bpObj.CarType + "'");
            //}


            //UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain.EntityList bomMainlist = UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain.Finder.FindAll(sb.ToString(), null);

            //int i = 1;

            //if (bomMainlist != null && bomMainlist.Count > 0)
            //{
            //    foreach (UFIDA.U9.Cust.XMJL.BommBE.Cust_Xmjl_MO_BomMain bomMain in bomMainlist)
            //    {
            //        BOMMainInfoDto bomMainInfoDto = new BOMMainInfoDto();

            //        bomMainInfoDto.ManufactureNo = bomMain.ManufactureNo.ID;//车号
            //        bomMainInfoDto.ContractNo = bomMain.ContractNo;//合同号
            //        bomMainInfoDto.CarType = bomMain.CarType;//车型
            //        bomMainInfoDto.ManufactureNo_Code = bomMain.ManufactureNo.Code;//编码
            //        bomMainInfoDto.ManufactureNo_Name = bomMain.ManufactureNo.Name;//项目名称
            //        bomMainInfoDto.No = i;//序号

            //        i++;

            //        BOMMainInfoDtolist.Add(bomMainInfoDto);
            //    }
            //}

            DataParamList lst = new DataParamList();
            lst.Add(DataParamFactory.CreateInput("@Org", UFIDA.U9.Base.Context.LoginOrg.ID, System.Data.DbType.Int64));
            lst.Add(DataParamFactory.CreateInput("@ManufactureNo", bpObj.ManufactureNo, System.Data.DbType.String));
            lst.Add(DataParamFactory.CreateInput("@ContractNo", bpObj.ContractNo, System.Data.DbType.String));
            lst.Add(DataParamFactory.CreateInput("@CarType", bpObj.CarType, System.Data.DbType.String));
            lst.Add(DataParamFactory.CreateInput("@DisburseType", bpObj.DisburseType, System.Data.DbType.Int32));
            System.Data.DataSet ds = new System.Data.DataSet();
            DataAccessor.RunSQL(DataAccessor.GetConn(), @"select distinct A.ManufactureNo,A.ContractNo,
                A.CarType,B.Code as ManufactureNo_Code,C.Name as ManufactureNo_Name 
                from Cust_Xmjl_MO_BomMain A left join CBO_Project B on A.ManufactureNo=B.ID 
                left join CBO_Project_Trl C on B.ID=C.ID  where A.Status=1 and A.DescFlexField_PrivateDescSeg2='True' 
                and A.Org=@Org and (@ManufactureNo='' or B.Code like @ManufactureNo) 
                and (@ContractNo='' or A.ContractNo like @ContractNo) and (@CarType='' or A.CarType like @CarType)
                and (isnull(@DisburseType,0)<=0 or A.DisburseType=@DisburseType) order by B.Code", lst, out ds);

            if (ds != null && ds.Tables.Count > 0)
            {
                System.Data.DataTable dataTable = ds.Tables[0];
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    BOMMainInfoDto bomMainInfoDto = new BOMMainInfoDto();

                    bomMainInfoDto.ManufactureNo = long.Parse(dataTable.Rows[i]["ManufactureNo"].ToString());//车号
                    bomMainInfoDto.ContractNo = dataTable.Rows[i]["ContractNo"].ToString();//合同号
                    bomMainInfoDto.CarType = dataTable.Rows[i]["CarType"].ToString();//车型
                    bomMainInfoDto.ManufactureNo_Code = dataTable.Rows[i]["ManufactureNo_Code"].ToString();//编码
                    bomMainInfoDto.ManufactureNo_Name = dataTable.Rows[i]["ManufactureNo_Name"].ToString();//项目名称
                    bomMainInfoDto.No = i + 1;//序号

                    BOMMainInfoDtolist.Add(bomMainInfoDto);
                }
            }

            return BOMMainInfoDtolist;
		}		
	}

	#endregion
	
	
}