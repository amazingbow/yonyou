namespace UFIDA.U9.Cust.XMQX.LaserLabBP.LaserLabDataProcessBP
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Text;
    using UFIDA.U9.Cust.XMQX.LaserLabBE.LaserLab;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.Util.Context;

    /// <summary>
    /// LbDataProcessBP partial 
    /// </summary>	
    public partial class LbDataProcessBP
    {
        internal BaseStrategy Select()
        {
            return new LbDataProcessBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class LbDataProcessBPImpementStrategy : BaseStrategy
    {
        public LbDataProcessBPImpementStrategy() { }
        private string JYTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "STOCK1.txt";
        private string BZTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "STOCK2.txt";
        private string CHTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "STOCK3.txt";
        private string BFTXT = ConfigurationManager.AppSettings["ProcessFilePath"] + "SCRAP.txt";
        private string _ErrorFilePath = ConfigurationManager.AppSettings["ErrorFilePath"];
        public override object Do(object obj)
        {
            LbDataProcessBP bpObj = (LbDataProcessBP)obj;
            int result = -1;
            try
            {
                switch (bpObj.ProcessType)
                {
                    case 0:
                        result = GoldenOilProcess(JYTXT);
                        break;
                    case 1:
                        result = PackingProcess(BZTXT);
                        break;
                    case 2:
                        result = ShipmentProcess(CHTXT);
                        break;
                    case 3:
                        result = ScrapProcess(BFTXT);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        private int ScrapProcess(string path)
        {
            if (!File.Exists(path)) return 2;
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            using (ISession session = Session.Open())
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    LaserLab lab = LaserLab.Finder.Find("LB='" + line + "'");
                    if (lab == null) continue;
                    lab.Cp = LBEnum.Scrap;
                    lab.ScarpDT = DateTime.Now;
                }
                session.Commit();
            }
            ModifyFileName(path, LBEnum.Scrap);
            return 1;
        }

        private int ShipmentProcess(string path)
        {
            if (!File.Exists(path)) return 2;
            StreamReader sr = new StreamReader(path, Encoding.Default);
            string errFileName = _ErrorFilePath + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            String line;
            bool flag = false;
            if (File.Exists(errFileName) == false)//如果不存在就创建file文件夹
            {
                FileStream fileStream = File.Create(errFileName);//创建该文件
                fileStream.Close();
            }
            StreamWriter sw = new StreamWriter(errFileName);
            using (ISession session = Session.Open())
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    if (line.Length > 20)
                    {
                        string batch = line.Substring(0, 5);
                        string tempstr = line.Substring(6).Trim();

                        string tempTime = tempstr.Substring(tempstr.Length - 15).Trim();
                        string time = tempTime.Substring(0, 8);
                        string laserLab = tempstr.Replace(tempTime, "").Trim();
                        LaserLab lab = LaserLab.Finder.Find("LB='" + laserLab + "'");
                        if (lab == null)
                        {
                            flag = true;
                            sw.WriteLine(line, Encoding.Default);
                        }
                        else
                        {
                            lab.ScanDate = DateTime.Parse(time);
                            lab.Cp = LBEnum.Shipment;
                            lab.ShipBN = batch;
                            lab.ShipDT = DateTime.Now;
                        }
                    }
                }
                session.Commit();
            }
            sw.Close();
            sr.Close();
            ModifyFileName(path, LBEnum.Shipment);
            if (!flag)//如果没有错误的就删掉
            {
                File.Delete(errFileName);
            }
            return flag ? 0 : 1;
        }
        private int PackingProcess(string path)
        {
            if (!File.Exists(path)) return 2;
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            using (ISession session = Session.Open())
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    LaserLab lab = LaserLab.Finder.Find("LB='" + line + "'");
                    if (lab == null) continue;
                    lab.Cp = LBEnum.Packing;
                    lab.ScarpDT = DateTime.Now;
                }
                session.Commit();
            }
            ModifyFileName(path, LBEnum.Packing);
            return 1;
        }
        private int GoldenOilProcess(string path)
        {
            if (!File.Exists(path)) return 2;
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            using (ISession session = Session.Open())
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    LaserLab lab = LaserLab.Finder.Find("LB='" + line + "'");
                    if (lab == null) continue;
                    lab.Cp = LBEnum.GoldOil;
                    lab.ScarpDT = DateTime.Now;
                }
                session.Commit();
            }
            ModifyFileName(path, LBEnum.GoldOil);
            return 1;
        }
        private void ModifyFileName(string path, LBEnum lBEnum)
        {
            var directory = DateTime.Now.ToString("yyyyMM");
            var fileName = DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";
            switch (lBEnum.Value)
            {
                case 1:
                        var jyDirectory = ConfigurationManager.AppSettings["ProcessFilePath"] + "/金油/" + directory;
                        if (!Directory.Exists(jyDirectory))
                    {
                        Directory.CreateDirectory(jyDirectory);
                    }
                        File.Move(path, jyDirectory + "/" + fileName);
                    break;
                case 2:
                        var bzDirectory = ConfigurationManager.AppSettings["ProcessFilePath"] + "/包装/" + directory;
                        if (!Directory.Exists(bzDirectory))
                    {
                        Directory.CreateDirectory(bzDirectory);
                    }
                        File.Move(path, bzDirectory + "/" + fileName);
                    break;
                case 3:
                    var chDirectory = ConfigurationManager.AppSettings["ProcessFilePath"] + "/出货/" + directory;
                    if (!Directory.Exists(chDirectory))
                    {
                        Directory.CreateDirectory(chDirectory);
                    }
                    File.Move(path, chDirectory + "/" + fileName);
                    break;
                case 4:
                       var bfDirectory = ConfigurationManager.AppSettings["ProcessFilePath"] + "/报废/" + directory;
                       if (!Directory.Exists(bfDirectory))
                    {
                        Directory.CreateDirectory(bfDirectory);
                    }
                       File.Move(path, bfDirectory + "/" + fileName);
                    break;
                default:
                    break;
            }
        }
    }

    #endregion


}