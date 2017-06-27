using System;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.Portal;
using UFSoft.UBF.UI.Portal.Components;
using UFSoft.UBF.UI.Portal.WebControls.WebParts;
using UFSoft.UBF.UI.ReviseLayout;

namespace UFIDA.U9.Cust.FJGX.UIHelper
{
    /// <summary>
    ///     布局帮助类
    /// </summary>
    public static class ReviseHelper
    {
        /// <summary>
        ///     重置界面布局
        /// </summary>
        public static void ReviseLayoutExtend(BaseWebForm webPart, WebPartManager webPartManager, HttpContext context,
            int direction = 0)
        {
            string pageId = CSContext.Current.PageId.ToLower();
            string rawUrl = CSContext.Current.RawUrl;
            const string blank = "blank";
            const string display = "display";
            bool flag = Convert.ToBoolean(CSContext.Current["orgChanged"]);
            try
            {
                if (rawUrl.Contains(display) && pageId != blank && webPartManager.WebParts.Count >= 1 && !flag)
                {
                    string screenParams = webPart.Page.Session[ContextKey._KEY_SCREEN_PARAMS] as string;
                    if (string.IsNullOrEmpty(screenParams))
                    {
                        HttpCookie httpCookie = context.Session[ContextKey._KEY_SCREEN_PARAMS] as HttpCookie;
                        if (httpCookie != null)
                        {
                            screenParams = httpCookie.Value;
                        }
                        if (string.IsNullOrEmpty(screenParams))
                        {
                            return;
                        }
                    }
                    string[] arrScreenParams = screenParams.Split(new[]
                    {
                        ':'
                    });
                    string key = arrScreenParams[0] + arrScreenParams[1];
                    if (webPart is UFNoAccessPart) return;
                    if (!ReviseConfigManager.ConfigExists()) return;
                    ReviseConfig reviseConfig = ReviseConfigManager.Get();
                    //if (!reviseConfig.Resolutions.ContainsKey(key)) return;
                    if (!reviseConfig.Revise) return;
                    webPart.Page.RegisterHiddenField("__Revise_KEY", "true");
                    webPart.Page.Session["__Revise_KEY"] = reviseConfig.Revise;
                    ReviseContext reviseContext = new ReviseContext(webPart);
                    reviseContext.ReviseDeviation = -10;
                    if (reviseContext.ReviseTarget == null) return;
                    //上下
                    if (webPartManager.WebParts.Count == 2 && direction == 0)
                    {
                        ReviseLayout2WebPartUpAndDown(webPart.Page, reviseContext, arrScreenParams, rawUrl);
                    }
                    //左右
                    if (webPartManager.WebParts.Count == 2 && direction == 1)
                    {
                        ReviseLayout2WebPartLeftAndRight(webPart.Page, reviseContext, arrScreenParams, rawUrl);
                    }
                    if (webPartManager.WebParts.Count == 4)
                    {
                        ReviseLayout4WebPart(webPart.Page, reviseContext, arrScreenParams, rawUrl);
                    }
                    reviseContext.ReviseRate = Convert.ToDouble(arrScreenParams[0])/1000.0 - 0.01;
                    reviseContext.Revise();
                }
            }
            catch
            {
            }
        }

        /// <summary>
        ///     2 webpart 上下 布局
        /// </summary>
        /// <param name="page"></param>
        /// <param name="reviseContext"></param>
        /// <param name="arrScreenParams"></param>
        /// <param name="rawUrl"></param>
        public static void ReviseLayout2WebPartUpAndDown(PageBase page, ReviseContext reviseContext,
            string[] arrScreenParams,
            string rawUrl)
        {
            double totalHeight = Convert.ToDouble(arrScreenParams[3]) - reviseContext.ReviseDeviation + 90;
            double totalWidth = Convert.ToDouble(arrScreenParams[2]);
            CSPage pageSettings = PageManagement.GetPageSettings();
            double onePartWidth = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Width);
            double onePartHeight = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Height);
            double twoPartWidth = Convert.ToDouble(pageSettings.Zones[0].Parts[1].Width);
            double twoPartHeight = Convert.ToDouble(pageSettings.Zones[0].Parts[1].Height);
            if (page.Session[rawUrl] == null)
            {
                reviseContext.ScreenAvailableHeight = totalHeight*onePartHeight/(onePartHeight + twoPartHeight);
                reviseContext.ScreenAvailableWidth = totalWidth;
                page.Session[rawUrl] = 1;
            }
            else if (page.Session[rawUrl] != null && (int) page.Session[rawUrl] == 1)
            {
                reviseContext.ScreenAvailableHeight = totalHeight*twoPartHeight/(onePartHeight + twoPartHeight);
                reviseContext.ScreenAvailableWidth = totalWidth;
                page.Session[rawUrl] = null;
            }
        }

        /// <summary>
        ///     2 webpart 左右 布局
        /// </summary>
        /// <param name="page"></param>
        /// <param name="reviseContext"></param>
        /// <param name="arrScreenParams"></param>
        /// <param name="rawUrl"></param>
        public static void ReviseLayout2WebPartLeftAndRight(PageBase page, ReviseContext reviseContext,
            string[] arrScreenParams,
            string rawUrl)
        {
            double totalHeight = Convert.ToDouble(arrScreenParams[3]) - reviseContext.ReviseDeviation-50;
            double totalWidth = Convert.ToDouble(arrScreenParams[2]);
            CSPage pageSettings = PageManagement.GetPageSettings();
            double onePartWidth = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Width);
            double onePartHeight = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Height);
            double twoPartWidth = Convert.ToDouble(pageSettings.Zones[1].Parts[0].Width);
            double twoPartHeight = Convert.ToDouble(pageSettings.Zones[1].Parts[0].Height);
            if (page.Session[rawUrl] == null)
            {
                reviseContext.ScreenAvailableHeight = totalHeight;
                reviseContext.ScreenAvailableWidth = totalWidth*onePartWidth/(onePartWidth + twoPartWidth);
                page.Session[rawUrl] = 1;
            }
            else if (page.Session[rawUrl] != null && (int) page.Session[rawUrl] == 1)
            {
                reviseContext.ScreenAvailableHeight = totalHeight;
                reviseContext.ScreenAvailableWidth = totalWidth*twoPartWidth/(onePartWidth + twoPartWidth);
                page.Session[rawUrl] = null;
            }
        }

        /// <summary>
        ///     4 webpart 布局
        /// </summary>
        /// <param name="page"></param>
        /// <param name="reviseContext"></param>
        /// <param name="arrScreenParams"></param>
        /// <param name="rawUrl"></param>
        public static void ReviseLayout4WebPart(PageBase page, ReviseContext reviseContext, string[] arrScreenParams,
            string rawUrl)
        {
            double totalHeight = Convert.ToDouble(arrScreenParams[3]) - reviseContext.ReviseDeviation + 40;
            double totalWidth = Convert.ToDouble(arrScreenParams[2]);
            CSPage pageSettings = PageManagement.GetPageSettings();
            double onePartWidth = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Width);
            double onePartHeight = Convert.ToDouble(pageSettings.Zones[0].Parts[0].Height);
            double twoPartWidth = Convert.ToDouble(pageSettings.Zones[0].Parts[1].Width);
            double twoPartHeight = Convert.ToDouble(pageSettings.Zones[0].Parts[1].Height);
            double threePartWidth = Convert.ToDouble(pageSettings.Zones[1].Parts[0].Width);
            double threePartHeight = Convert.ToDouble(pageSettings.Zones[1].Parts[0].Height);
            double fourWidth = Convert.ToDouble(pageSettings.Zones[1].Parts[1].Width);
            double fourHeight = Convert.ToDouble(pageSettings.Zones[1].Parts[1].Height);
            if (page.Session[rawUrl] == null)
            {
                reviseContext.ScreenAvailableHeight = totalHeight*onePartHeight/(onePartHeight + twoPartHeight);
                reviseContext.ScreenAvailableWidth = totalWidth*onePartWidth/(onePartWidth + threePartWidth);
                page.Session[rawUrl] = 1;
            }
            else if (page.Session[rawUrl] != null && (int) page.Session[rawUrl] == 1)
            {
                reviseContext.ScreenAvailableHeight = totalHeight*twoPartHeight/(onePartHeight + twoPartHeight);
                reviseContext.ScreenAvailableWidth = totalWidth*twoPartWidth/(onePartWidth + threePartWidth);
                page.Session[rawUrl] = 2;
            }
            else if (page.Session[rawUrl] != null && (int) page.Session[rawUrl] == 2)
            {
                reviseContext.ScreenAvailableHeight = totalHeight*threePartHeight/(threePartHeight + fourHeight);
                reviseContext.ScreenAvailableWidth = totalWidth*threePartWidth/(onePartWidth + threePartWidth);
                page.Session[rawUrl] = 3;
            }
            else if (page.Session[rawUrl] != null && (int) page.Session[rawUrl] == 3)
            {
                reviseContext.ScreenAvailableHeight = totalHeight*fourHeight/(threePartHeight + fourHeight);
                reviseContext.ScreenAvailableWidth = totalWidth*fourWidth/(onePartWidth + threePartWidth);
                page.Session[rawUrl] = null;
            }
        }
    }
}