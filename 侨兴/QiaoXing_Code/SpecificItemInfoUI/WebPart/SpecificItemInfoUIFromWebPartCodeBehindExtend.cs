using System;
using System.Text;
using System.Data;
using UFSoft.UBF.Util.DataAccess;
using UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo;
using UFIDA.U9.Cust.XMQX.SpecilFicItemInfoBP.SpeciFicItemInfo.Proxy;
using System.Collections.Generic;
using UFSoft.UBF.UI.MD.Runtime;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.XMQX.SpecificItemInfoUI.SpecificItemInfoUIModel
{
    public partial class SpecificItemInfoUIFromWebPart
    {
        #region Custome eventBind
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ShowSpecificitemInfoMainView.Clear();
            DataParamList lst = new DataParamList();
            StringBuilder stb = new StringBuilder();
            List<string> DifList = new List<string>();
            if (string.IsNullOrEmpty(this.Model.FindSpecificItemInfoMainView.FocusedRecord.Wh.ToString())) return;
            lst.Add(DataParamFactory.CreateInput("@ID", this.Model.FindSpecificItemInfoMainView.FocusedRecord.Wh.Value, System.Data.DbType.Int64));
            stb.Append(@"Select Wh,A.StorageType,C.Code as Wh_Code,B.Name as Wh_Name,ItemInfo_ItemID,ItemInfo_ItemCode,ItemInfo_ItemName,
                ISNULL(StoreQtyCU,0) as StoreQtyCU,
                isnull((Select SUM(p.CurOrgToPOQtyTU) from PR_PRLine p where p.DemandCode=3348 and p.ItemInfo_ItemID=A.ItemInfo_ItemID),0) as CurOrgToPOQtyTU, 
                isnull((Select SUM(p.ApprovedQtyPU) from PR_PRLine p where p.DemandCode=3348 and p.ItemInfo_ItemID=A.ItemInfo_ItemID),0) as PRQty,
                isnull((Select SUM(pm.PurQtyTU) from PM_POLine pm inner join PM_PurchaseOrder pmp on pm.PurchaseOrder=pmp.ID  where pm.DemondCode=3348 and pm.ItemInfo_ItemID=A.ItemInfo_ItemID),0) as PMQty,
                Isnull((select SUM(rcv.ArriveQtyPU) from PM_RcvLine rcv where rcv.ItemInfo_ItemID=A.ItemInfo_ItemID and rcv.DescFlexSegments_PrivateDescSeg1='3348'),0) as PMOutQty,
                Isnull((select SUM(rcv.ArriveQtyPU) from PM_RcvLine rcv where rcv.[Status] in (0,3) and rcv.ItemInfo_ItemID=A.ItemInfo_ItemID and rcv.DescFlexSegments_PrivateDescSeg1='3348'),0) as RcvQty 
                from InvTrans_WhQoh A inner join CBO_Wh_Trl B on A.Wh=B.ID and B.SysMLFlag='zh-CN' inner join CBO_Wh C on A.Wh=C.ID where A.Wh=@ID");            
            switch (string.IsNullOrEmpty(this.ItemMaster92.Value.ToString()))
            {
                case false:
                    string[] StrList = this.ItemMaster92.Value.ToString().Split(new char[1] { ',' });
                    StringBuilder strbuilder = new StringBuilder();
                    foreach (var str in StrList)
                    {
                        strbuilder.Append("'" + str.ToString() + "',");
                        DifList.Add(str.ToString());
                    }
                    //var strbuilderstring = strbuilder.ToString().TrimEnd(new char[] { ',' });
                    stb.Append(" and A.ItemInfo_ItemCode in (" + strbuilder.ToString().TrimEnd(new char[] { ',' }) + ") ");
                    break;
                case true:
                    if (!string.IsNullOrEmpty(this.LikeName182.Value.ToString()))
                    {
                        stb.Append(" and A.ItemInfo_ItemName like '%" + this.LikeName182.Value + "%'");
                    }
                    break;
            }
            //为数据集添加字段
            //lst.Add(DataParamFactory.CreateInput("@Org", UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID, System.Data.DbType.Int64));
            //定义缓存数据
            System.Data.DataSet ds = new System.Data.DataSet();
            //运行RunSQl传递oql查询条件.给缓存数据集中添加相应的查询字段
            DataAccessor.RunSQL(DataAccessor.GetConn(),
            stb.ToString(), lst, out ds);
            if (ds != null && ds.Tables.Count > 0)
            {
                //将缓存的数据集用表承载
                System.Data.DataTable dataTable = ds.Tables[0];
                //取出表中的行信息       
                List<string> itemList = new List<string>();
                int a = 0;
                foreach (DataRow item in dataTable.Rows)
                {
                    //item[0]就是你的第一个属性值。
                    itemList.Add(item["ItemInfo_ItemCode"].ToString());
                    var Record = this.Model.ShowSpecificitemInfoMainView.AddNewUIRecord();
                    Record.ItemMaster = long.Parse(item["ItemInfo_ItemID"].ToString());
                    Record.ItemMaster_Code = item["ItemInfo_ItemCode"].ToString();
                    Record.ItemMaster_Name = item["ItemInfo_ItemName"].ToString();
                    Record.Wh = long.Parse(item["Wh"].ToString());
                    Record.Wh_Code = item["Wh_Code"].ToString();
                    Record.Wh_Name = item["Wh_Name"].ToString();
                    Record.WhQty = decimal.Parse(item["StoreQtyCU"].ToString());
                    Record.DoingPrQty = decimal.Parse(item["PRQty"].ToString()) - decimal.Parse(item["CurOrgToPOQtyTU"].ToString());
                    Record.PrQty = 0;
                    Record.RecQty = decimal.Parse(item["RcvQty"].ToString());
                    Record.DoingQty = decimal.Parse(item["PMQty"].ToString()) - decimal.Parse(item["PMOutQty"].ToString());
                    Record.ReqData = System.DateTime.Now.AddDays(15);
                }
                foreach (var item in itemList)
                {
                    DifList.Remove(item);
                }
                foreach (var List in DifList)
                {
                    //使用料品编号查料品
                    DataParamList Dlst = new DataParamList();
                    //为数据集添加字段
                    Dlst.Add(DataParamFactory.CreateInput("@Code", List, System.Data.DbType.String));
                    //定义缓存数据
                    System.Data.DataSet Dds = new System.Data.DataSet();
                    //运行RunSQl传递oql查询条件.给缓存数据集中添加相应的查询字段
                    DataAccessor.RunSQL(DataAccessor.GetConn(),
                    @"Select top 1 A.ID,A.Code as ItemCode,A.Name as ItemName,
                0 as StoreQtyCU,
                isnull((Select SUM(p.CurOrgToPOQtyTU) from PR_PRLine p where p.DemandCode=3348 and p.ItemInfo_ItemID=A.ID),0) as CurOrgToPOQtyTU, 
                isnull((Select SUM(p.ApprovedQtyPU) from PR_PRLine p where p.DemandCode=3348 and p.ItemInfo_ItemID=A.ID),0) as PRQty,
                isnull((Select SUM(pm.PurQtyTU) from PM_POLine pm inner join PM_PurchaseOrder pmp on pm.PurchaseOrder=pmp.ID where pm.DemondCode=3348 and pm.ItemInfo_ItemID=A.ID),0) as PMQty,
                Isnull((select SUM(rcv.ArriveQtyPU) from PM_RcvLine rcv where  rcv.ItemInfo_ItemID=A.ID and rcv.DescFlexSegments_PrivateDescSeg1='3348'),0) as PMOutQty,
                Isnull((select SUM(rcv.ArriveQtyPU) from PM_RcvLine rcv where  rcv.[Status] in (0,3) and rcv.ItemInfo_ItemID=A.ID and rcv.DescFlexSegments_PrivateDescSeg1='3348'),0) as RcvQty from CBO_ItemMaster A where A.Code =@Code", Dlst, out Dds);
                    if (Dds != null && Dds.Tables.Count > 0)
                    {
                        //将缓存的数据集用表承载
                        System.Data.DataTable DdataTable = Dds.Tables[0];
                        //取出表中的行信息                         
                        foreach (DataRow Ditem in DdataTable.Rows)
                        {
                            var Record = this.Model.ShowSpecificitemInfoMainView.AddNewUIRecord();
                            Record.ItemMaster = long.Parse(Ditem["ID"].ToString());
                            Record.ItemMaster_Code = List;
                            Record.ItemMaster_Name = Ditem["ItemName"].ToString();
                            Record.Wh = long.Parse(this.Wh83.Key);
                            Record.Wh_Code = this.Wh83.Value.ToString();
                            Record.Wh_Name = this.Wh83.Text;
                            Record.WhQty = decimal.Parse(Ditem["StoreQtyCU"].ToString());
                            Record.PrQty = 0;
                            Record.RecQty = decimal.Parse(Ditem["RcvQty"].ToString()) ;
                            Record.DoingPrQty = decimal.Parse(Ditem["PRQty"].ToString()) - decimal.Parse(Ditem["CurOrgToPOQtyTU"].ToString()); ;
                            Record.DoingQty = decimal.Parse(Ditem["PMQty"].ToString()) - decimal.Parse(Ditem["PMOutQty"].ToString());
                            Record.ReqData = System.DateTime.Now.AddDays(15);                           
                        }
                    }              
                }
            }
            BtnFind_Click_DefaultImpl(sender, e);
        }
        private void BtnReqPRExe_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.ClearErrorMessage();
            if (this.Model.FindSpecificItemInfoMainView.FocusedRecord.Operators == null) throw new Exception("请选择业务人员！");
            SpeciFicItemInfoBPProxy proxy = new SpeciFicItemInfoBPProxy();
            proxy.Operators = this.Model.FindSpecificItemInfoMainView.FocusedRecord.Operators ?? 0L;
            List<SpeciFicItemInfoDtoData> SpeciFicItemInfoDtoList = new List<SpeciFicItemInfoDtoData>();
            IList<IUIRecord> getSellectRecord = this.Model.ShowSpecificitemInfoMainView.GetSelectRecords();
            
            if (this.Model.ShowSpecificitemInfoMainView.Records.Count == 0) return;
            if (getSellectRecord.Count > 0)
            {
                foreach (IUIRecord record in getSellectRecord)
                {
                    //if (record.IsReqPR == false) continue;
                    if (decimal.Parse(record["PrQty"].ToString()) == 0) throw new Exception("料品" + record["ItemMaster_Name"].ToString() + "请购数量不能为空,请输入请购数量！");
                    if (DateTime.Parse(record["ReqData"].ToString()) < System.DateTime.Now) throw new Exception("需求日期" + DateTime.Parse(record["ReqData"].ToString()) + "需求日期必须大于当前时间，请选择！");
                    SpeciFicItemInfoDtoData SpeciFicItemInfoDto = new SpeciFicItemInfoDtoData();
                    SpeciFicItemInfoDto.Wh = long.Parse(record["Wh"].ToString());
                    SpeciFicItemInfoDto.Wh_Code = record["Wh_Code"].ToString();
                    SpeciFicItemInfoDto.Wh_Name = record["Wh_Name"].ToString();
                    SpeciFicItemInfoDto.ItemMaster = long.Parse(record["ItemMaster"].ToString());
                    SpeciFicItemInfoDto.ItemMaster_Code = record["ItemMaster_Code"].ToString();
                    SpeciFicItemInfoDto.ItemMaster_Name = record["ItemMaster_Name"].ToString();
                    SpeciFicItemInfoDto.ReqPRQty = decimal.Parse(record["PrQty"].ToString());
                    SpeciFicItemInfoDto.ReqDate = DateTime.Parse(record["ReqData"].ToString());
                    SpeciFicItemInfoDtoList.Add(SpeciFicItemInfoDto);

                }
            }
            else
            {                
                foreach (ShowSpecificitemInfoMainViewRecord record in this.Model.ShowSpecificitemInfoMainView.Records)
                {
                    if (record.IsReqPR == false) continue;
                    if (record.PrQty == 0) throw new Exception("料品" + record.ItemMaster_Name + "请购数量不能为空,请输入请购数量！");
                    if (record.ReqData < System.DateTime.Now) throw new Exception("需求日期" + record.ReqData + "需求日期必须大于当前时间，请选择！");
                    SpeciFicItemInfoDtoData SpeciFicItemInfoDto = new SpeciFicItemInfoDtoData();
                    SpeciFicItemInfoDto.Wh = record.Wh.Value;
                    SpeciFicItemInfoDto.Wh_Code = record.Wh_Code;
                    SpeciFicItemInfoDto.Wh_Name = record.Wh_Name;
                    SpeciFicItemInfoDto.ItemMaster = long.Parse(record.ItemMaster.Value.ToString());
                    SpeciFicItemInfoDto.ItemMaster_Code = record.ItemMaster_Code;
                    SpeciFicItemInfoDto.ItemMaster_Name = record.ItemMaster_Name;
                    SpeciFicItemInfoDto.ReqPRQty = record.PrQty.Value;
                    SpeciFicItemInfoDto.ReqDate = record.ReqData.Value;
                    SpeciFicItemInfoDtoList.Add(SpeciFicItemInfoDto);

                }
            }
            proxy.SpeciFicItemInfoDto = SpeciFicItemInfoDtoList;
            var str = proxy.Do();
            if (string.IsNullOrEmpty(str)) return;
            UFSoft.UBF.UI.AtlasHelper.RegisterAtlasStartupScript(this.Page, this.Page.GetType(), "JavaScriptExecQueue", "alert('" + str + "');", true);
            //BtnFind_Click_DefaultImpl(sender, e);
            BtnReqPRExe_Click_DefaultImpl(sender, e);
        }






        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            OnLoadData_DefaultImpl(sender);
            if (this.Model.FindSpecificItemInfoMainView.FocusedRecord == null)
                this.Model.FindSpecificItemInfoMainView.FocusedRecord = this.Model.FindSpecificItemInfoMainView.AddNewUIRecord();
        }
        private void OnDataCollect_Extend(object sender)
        {
            OnDataCollect_DefaultImpl(sender);
        }
        #endregion

        #region 自己扩展 Extended Event handler
        public void AfterOnLoad()
        {

        }

        public void AfterCreateChildControls()
        {



        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {


        }


        #endregion

        #endregion

    }
}