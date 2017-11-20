namespace UFIDA.U9.Cust.SeeBestAdvertisementBP.AdvApproveBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApplyBE;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE;
    using UFSoft.UBF.Util.DataAccess;

	/// <summary>
	/// BatchCreateAdvApprove partial 
	/// </summary>	
	public partial class BatchCreateAdvApprove 
	{	
		internal BaseStrategy Select()
		{
			return new BatchCreateAdvApproveImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class BatchCreateAdvApproveImpementStrategy : BaseStrategy
	{
		public BatchCreateAdvApproveImpementStrategy() { }

		public override object Do(object obj)
		{						
			BatchCreateAdvApprove bpObj = (BatchCreateAdvApprove)obj;

            int iBatchCreateQty = 0;

            AdvApplyBE.EntityList applyLst = AdvApplyBE.Finder.FindAll("(ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");
            SpecialApplyBE.EntityList speLst = SpecialApplyBE.Finder.FindAll("(ApplyDate>='" + bpObj.StartDate.ToString("yyyy-MM-dd") + "' and ApplyDate<='" + bpObj.EndDate.ToString("yyyy-MM-dd 23:59:59") + "')");

            if (applyLst.Count > 0 || speLst.Count > 0)
            {
                long[] lngApplyDeptID = new long[applyLst.Count + speLst.Count];
                int i = 0;
                foreach (var app in applyLst)
                {
                    if (app.ApplyDept != null)
                    {
                        lngApplyDeptID[i] = app.ApplyDept.ID;
                        i++;
                    }
                }
                foreach (var spe in speLst)
                {
                    if (spe.ApplyDept != null)
                    {
                        lngApplyDeptID[i] = spe.ApplyDept.ID;
                        i++;
                    }
                }

                long[] new_lngApplyDeptID;
                if (lngApplyDeptID.Length > 1)
                {
                    new_lngApplyDeptID = DelRepeatData(lngApplyDeptID);
                }
                else
                {
                    new_lngApplyDeptID = lngApplyDeptID;
                }

                if (new_lngApplyDeptID.Length > 0)
                {
                    using (ISession session = Session.Open())
                    {
                        for (int k = 0; k < new_lngApplyDeptID.Length; k++)
                        {
                            AdvApproveBE doc = AdvApproveBE.Create();

                            doc.AdvApproveDocType = UFIDA.U9.Cust.SeeBestAdvertisementBE.SpecialApplyDocTypeBE.SpecialApplyDocType.Finder.Find("AdvDocEnum=2", null);
                            doc.AdvApplyCust = CBO.SCM.Customer.Customer.Finder.FindByID(new_lngApplyDeptID[k]);
                            doc.StartDate = bpObj.StartDate;
                            doc.EndDate = bpObj.EndDate;
                            doc.DocStatus = UFIDA.U9.Cust.SeeBestAdvertisementBE.AdvertisementApproveBE.AdvAppStatusEnum.OpenL;
                            doc.BusinessDate = System.DateTime.Now;

                            #region 单号赋默认值 -- 客户简称+YYMM+2流水号
                            string strCustomerAbbreviation = "";
                            if (doc.AdvApplyCust != null)
                            {
                                if (string.IsNullOrEmpty(doc.AdvApplyCust.DescFlexField.PrivateDescSeg11))
                                {
                                    strCustomerAbbreviation = "";
                                }
                                else
                                {
                                    strCustomerAbbreviation = doc.AdvApplyCust.DescFlexField.PrivateDescSeg11;
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

                            doc.DocNo = strCustomerAbbreviation + System.DateTime.Now.ToString("yyMM") + strRunningCode;
                            #endregion

                            #region 依据广告申请单创建行数据
                            foreach (var app in applyLst)
                            {
                                if (app.ApplyDept != null)
                                {
                                    if (app.ApplyDept.ID == new_lngApplyDeptID[k])
                                    {
                                        AdvApproveLine docline = AdvApproveLine.Create(doc);

                                        docline.Location = app.LocationQY;
                                        string strVerificationLevel = "";
                                        string strAdvCarrierCode = "";
                                        strVerificationLevel = app.ApplyDept.DescFlexField.PrivateDescSeg13;
                                        docline.AdvAppCustName = app.ApplyDept.Name;
                                        docline.Country = app.LocationXZ;
                                        docline.CustCounterName = app.CustConterName;
                                        docline.RelPeople = app.RelPeople;
                                        docline.RelPhone = app.CustPhone;
                                        docline.CustAddress = app.CustAddress;
                                        docline.Width = app.BMWidth;
                                        docline.Thick = app.BMThick;
                                        docline.Height = app.BMHight;
                                        docline.Area = app.BMArea;
                                        docline.ApplyQty = app.Qty;
                                        docline.ActualApproveQty = app.Qty;
                                        docline.ApplyAdvCode = app.AdvCode;
                                        if (app.AdvCarrier != null)
                                        {
                                            docline.AdvCarrier = app.AdvCarrier.Name;
                                            docline.AdvCarrierCode = app.AdvCarrier.Code;
                                            strAdvCarrierCode = app.AdvCarrier.Code;
                                        }
                                        else
                                        {
                                            docline.AdvCarrier = "";
                                            docline.AdvCarrierCode = "";
                                            strAdvCarrierCode = "";
                                        }
                                        #region 根据办事处核销等级、广告载体物料自动匹配广告载体报销价目表的价格
                                        decimal deActualPrice = 0M;
                                        if (string.IsNullOrEmpty(strVerificationLevel) || string.IsNullOrEmpty(strAdvCarrierCode))
                                        {
                                            deActualPrice = 0;
                                        }
                                        else
                                        {
                                            UFIDA.U9.SPR.SalePriceList.SalePriceLine salePriceLine = UFIDA.U9.SPR.SalePriceList.SalePriceLine.Finder.Find("DescFlexField.PubDescSeg2='" + strVerificationLevel
                                        + "' and ItemInfo.ItemCode='" + strAdvCarrierCode
                                        + "' and (ToDate>='" + app.ApplyDate.ToString("yyyy-MM-dd") + "' and FromDate<='" + app.ApplyDate.ToString("yyyy-MM-dd 23:59:59") + "')");
                                            if (salePriceLine != null)
                                            {
                                                deActualPrice = salePriceLine.Price;
                                            }
                                        }
                                        #endregion
                                        docline.ActualPrice = deActualPrice;
                                        docline.Discount = 1;
                                        foreach (var item in app.AdvAboutBE)
                                        {
                                            docline.AdvItem += item.Code + "/";
                                        }
                                        if (docline.AdvItem != null)
                                        {
                                            docline.AdvItem = docline.AdvItem.TrimEnd('/');
                                        }
                                        else
                                        {
                                            docline.AdvItem = "";
                                        }
                                        docline.OtherInfo = app.ID;
                                        docline.Momo = "";
                                        docline.ApplyDate = app.ApplyDate;
                                        docline.TotalMoney = docline.Price * docline.ApplyQty * docline.Area;
                                        docline.ApproveMoney = docline.ActualApproveQty * docline.Area * docline.ActualPrice * docline.Discount;

                                        #region 如果广告申请单封底的面积>0，再新增一行数据
                                        if (app.DZArea > 0)
                                        {
                                            AdvApproveLine docline1 = AdvApproveLine.Create(doc);

                                            docline1.Location = app.LocationQY;
                                            docline1.AdvAppCustName = app.ApplyDept.Name;
                                            docline1.Country = app.LocationXZ;
                                            docline1.CustCounterName = app.CustConterName;
                                            docline1.RelPeople = app.RelPeople;
                                            docline1.RelPhone = app.CustPhone;
                                            docline1.CustAddress = app.CustAddress;
                                            docline1.Width = app.DZWidth;
                                            docline1.Thick = app.DZThick;
                                            docline1.Height = 0;
                                            docline1.Area = app.DZArea;
                                            docline1.ApplyQty = 0;
                                            docline1.ActualApproveQty = 0;
                                            docline1.ApplyAdvCode = app.AdvCode;
                                            if (app.AdvCarrier != null)
                                            {
                                                docline1.AdvCarrier = app.AdvCarrier.Name;
                                                docline1.AdvCarrierCode = app.AdvCarrier.Code;
                                            }
                                            else
                                            {
                                                docline1.AdvCarrier = "";
                                                docline1.AdvCarrierCode = "";
                                            }
                                            foreach (var item in app.AdvAboutBE)
                                            {
                                                docline1.AdvItem += item.Code + "/";
                                            }
                                            if (docline1.AdvItem != null)
                                            {
                                                docline1.AdvItem = docline1.AdvItem.TrimEnd('/');
                                            }
                                            else
                                            {
                                                docline1.AdvItem = "";
                                            }
                                            docline1.ActualPrice = deActualPrice;
                                            docline1.Discount = 1;
                                            docline1.OtherInfo = app.ID;
                                            docline1.Momo = "封底";
                                            docline1.ApplyDate = app.ApplyDate;
                                            docline1.TotalMoney = docline1.Price * docline1.Area;
                                            docline1.ApproveMoney = docline1.Area * docline1.ActualPrice * docline1.Discount;
                                        }
                                        #endregion
                                    }
                                }
                            }
                            #endregion

                            #region 依据专柜申请单创建行数据
                            foreach (var spe in speLst)
                            {
                                foreach (var item in spe.SpecialSizeBE)
                                {
                                    if (spe.ApplyDept != null)
                                    {
                                        if (spe.ApplyDept.ID == new_lngApplyDeptID[k])
                                        {
                                            AdvApproveLine docline = AdvApproveLine.Create(doc);

                                            docline.Location = "";
                                            string strVerificationLevel = "";
                                            string strAdvCarrierCode = "";
                                            strVerificationLevel = spe.ApplyDept.DescFlexField.PrivateDescSeg13;
                                            docline.AdvAppCustName = spe.ApplyDept.Name;
                                            docline.Country = "";
                                            docline.CustCounterName = spe.CustConterName;
                                            docline.RelPeople = "";
                                            docline.RelPhone = spe.CustPhone;
                                            docline.CustAddress = spe.CustAddress;
                                            docline.Width = item.Width;
                                            docline.Thick = item.Thick;
                                            docline.Height = item.Hight;
                                            docline.Area = item.Area;
                                            docline.ApplyQty = item.Qty;
                                            docline.ActualApproveQty = item.Qty;
                                            docline.ApplyAdvCode = spe.AdvCode;
                                            if (item.AdvCarrier != null)
                                            {
                                                docline.AdvCarrier = item.AdvCarrier.Name;
                                                docline.AdvCarrierCode = item.AdvCarrier.Code;
                                                strAdvCarrierCode = item.AdvCarrier.Code;
                                            }
                                            else
                                            {
                                                docline.AdvCarrier = "";
                                                docline.AdvCarrierCode = "";
                                                strAdvCarrierCode = "";
                                            }
                                            #region 根据办事处核销等级、广告载体物料自动匹配广告载体报销价目表的价格
                                            decimal deActualPrice = 0M;
                                            if (string.IsNullOrEmpty(strVerificationLevel) || string.IsNullOrEmpty(strAdvCarrierCode))
                                            {
                                                deActualPrice = 0;
                                            }
                                            else
                                            {
                                                UFIDA.U9.SPR.SalePriceList.SalePriceLine salePriceLine = UFIDA.U9.SPR.SalePriceList.SalePriceLine.Finder.Find("DescFlexField.PubDescSeg2='" + strVerificationLevel
                                        + "' and ItemInfo.ItemCode='" + strAdvCarrierCode
                                        + "' and (ToDate>='" + spe.ApplyDate.ToString("yyyy-MM-dd") + "' and FromDate<='" + spe.ApplyDate.ToString("yyyy-MM-dd 23:59:59") + "')");
                                                if (salePriceLine != null)
                                                {
                                                    deActualPrice = salePriceLine.Price;
                                                }
                                            }
                                            #endregion
                                            docline.ActualPrice = deActualPrice;
                                            docline.Discount = 1;
                                            if (item.DisplayProductType != null)
                                            {
                                                docline.AdvItem = item.DisplayProductType.Description;
                                            }
                                            else
                                            {
                                                docline.AdvItem = "";
                                            }
                                            docline.OtherInfo = spe.ID;
                                            docline.Momo = "";
                                            docline.ApplyDate = spe.ApplyDate;
                                            docline.TotalMoney = docline.Price * docline.ApplyQty * docline.Area;
                                            docline.ApproveMoney = docline.ActualApproveQty * docline.Area * docline.ActualPrice * docline.Discount;
                                        }
                                    }
                                }
                            }
                            #endregion

                            iBatchCreateQty++;
                        }
                        session.Commit();
                    }
                }
            }

            return iBatchCreateQty;
		}

        //去重复算法
        static long[] DelRepeatData(long[] a)
        {
            int len = 0;
            long[] b = new long[a.Length];
            for (int i = 0; i < a.Length; i++, len++)
            {
                b[len] = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        len--; break;
                    }
                }
            }
            long[] new_a = new long[len];
            for (int k = 0; k < len; k++)
            {
                new_a[k] = b[k];
            }
            return new_a;
        }
	}

	#endregion
	
	
}