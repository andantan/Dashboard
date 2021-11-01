using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;

using System.Windows.Forms;

using static Dashboard.DataSettings;


namespace Dashboard
{

    // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
    //
    // CEFSharpController은 Mainform에서 CryptosForm, PortfolioForm, ComponentForm 내부의
    // TradingView 차트를 띄어주기위한 Controller입니다.
    // 
    // TradingView 차트를 뛰어주는 html소스는 
    // Dashboard\Dashboard\bin\Debug\chartHtmls 에 모두 모여있습니다.
    //
    // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
    class CEFSharpController
    {
        private static ChromiumWebBrowser browser;

        public static void initBrowser()
        {
            // CEFSharp의 ChromiumWebBrowser의 세팅을 만들어줍니다.

            var settings = new CefSettings();

            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "localfolder",
                DomainName = "cefsharp",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                    rootFolder: CurrentDirectoryPath + "\\chartHtmls",
                    hostName: "cefsharp",
                    defaultPage: "BTCKRW.html"
                )
            });

            Cef.Initialize(settings);

            browser = new ChromiumWebBrowser("localfolder://cefsharp/");
        }

        public static void AttachBrowser(Panel panel)
        {
            // 패널에 부착시킵니다.

            panel.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        public static void DetachBrowser(Panel panel)
        {
            // 패널에서로부터 제거합니다.

            panel.Controls.Remove(browser);
        }

        public static void LoadNewUrl(string UrlPath)
        {
            // 새로운 차트를 띄어줍니다.

            browser.LoadHtml(System.IO.File.ReadAllText(UrlPath));
        }
    }
}
