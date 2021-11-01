using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;

using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using System.Threading;

using static Dashboard.DataSettings;

namespace Dashboard
{
    public partial class MainForm : Form
    {
        // !!!!!!!!!!!!!!! 교수님! DataSettings.cs의 Path 변수 확인을 꼭 먼저 부탁드립니다. !!!!!!!!!!!!!!!

        private Form currentChildForm;

        private CryptosForm CryptosForm;
        private PortfolioForm PortfolioForm;
        private ComponentForm ComponentForm;

        private string time;

        Thread LoadPortfolio;

        public MainForm()
        {
            InitializeComponent();

            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // MainForm의 panelFormAttachment 패널에 폼을 부착 및 제거 하도록 설계했습니다.
            // 
            // 또한, FormThreadPool.cs의 Pool에 쓰레드를 추가하여 MainForm이 실행되는 
            // 동안에 DataSettings.cs에서 설정한 Python 스크립트를 지속적으로 실행할 수
            // 있는 쓰레드를 실행 중이므로 CryptosForm, PortfolioForm, ComponentForm 총 
            // 세 개의 폼을 먼저 생성하여 쓰레드 실행 및 패널에 부착/제거에 편하도록
            // 설계하였습니다.
            //
            // Pool에 대한 다른 설명은 FormThreadPool.cs에서 추가 설명하였습니다.
            //
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

            CryptosForm = new CryptosForm();
            PortfolioForm = new PortfolioForm();
            ComponentForm = new ComponentForm();

            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // 업비트 거래소의 포트폴리오 데이터는 PortfolioForm, ComponentForm 두 개의
            // 폼에서 데이터를 공유해야하므로 MainForm에서 쓰레드를 생성 및 실행합니다.
            // 
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

            LoadPortfolio = new Thread(new ThreadStart(LoadPortfolioByUpbitAPI))
            {
                IsBackground = true
            };

            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // WebView와 WebBrowser는 Window Internet Explorer 기반이기 때문에 
            // JavaScript 실행시 문제가 생겨 크롬 기반인 CEFSharp을 이용합니다.
            //
            // 또한, CEFSharp의 ChromiumWebBrowser은 한 번 Scheme이 설정되면 
            // 재설정이 어려워 Mainform에서 CryptosForm, PortfolioForm, ComponentForm
            // 세 개의 폼에 대한 브라우저 Attach, Detach 컨트롤을 가지고 있도록
            // CEFSharpController.cs를 설계하였습니다..
            //
            // 이 외의 다른 설명은 CEFSharpController.cs에서 추가 설명하였습니다.
            //
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            CEFSharpController.initBrowser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // MainForm이 시작되면 다른 CryptosForm을 패널에 부착합니다.
            btnCryptos.PerformClick();

            FormThreadPool.AddThreadToPool(LoadPortfolio);

            LoadPortfolio.Start();
        }

        private void LoadPortfolioByUpbitAPI()
        {

            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // 이 설명을 읽기 전에 Executors.cs 소스 내부의 설명을 먼저 읽고 오시면은
            // 더욱 이해하기 수월합니다.
            //
            // 이 쓰레드 전용 메소드는 Upbit API를 이용하여 포트폴리오에 대한 정보를 가져옵니다.
            //
            // 정해진 주기마다 Executors.cs의 MainFormsExecutePythonsScript를 실행한 후 
            // DataManager의 UpbitPortfolioPythonScriptExecutorResult에 저장합니다.
            //
            // 후에 PortfolioForm과 ComponentForm의 데이터그리드뷰의 데이터소스를 만들어준 후
            // PortfolioForm과 ComponentForm에서 관련 데이터를 표현하는 레이블과 차트 등을
            // 설정합니다.
            //
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

            while (true)
            {
                try
                {
                    if (DateTime.Now.Second % PORTFOLIO_LOADER_TICK == 0)
                    {
                        time = DateTime.Now.ToString();

                        DataManager.UpbitPortfolioPythonScriptExecutorResult = Executors.MainFormsExecutePythonsScript(PyUpbitPath, PythonPath);

                        DataManager.SetPortfolioFormDataGridDataSource();
                        DataManager.SetComponentFormDataGridSource();

                        Invoke(new Action(() =>
                        {
                            PortfolioForm.ComponentPieChartSetter();
                            PortfolioForm.PortfolioLabelDataSetter(time);

                            ComponentForm.DataGridViewSetter();
                            ComponentForm.PriceAndPremiumSetter(true, time);
                        }));
                    }
                }
                catch (ThreadAbortException)
                {
                    break;
                }
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            // panelFormAttachment에 폼을 부착 및 제거합니다.

            if (currentChildForm != null)
            {
                panelFormAttachment.Controls.Remove(currentChildForm);
            }

            currentChildForm = ChildForm;

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            panelFormAttachment.Controls.Add(ChildForm);
            panelFormAttachment.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnSelected(Button button, Panel panel)
        {
            // 버튼을 클릭했을 때의 이펙트를 만들어줍니다.
            panel.Height = button.Height;
            panel.Top = button.Top;
            panel.Left = button.Left;

            button.BackColor = Color.FromArgb(46, 54, 73);
            textBoxOption.Text = button.Text;
        }

        private void btnCryptos_Click(object sender, EventArgs e)
        {
            btnSelected(btnCryptos, panelNav);

            OpenChildForm(CryptosForm);

            CryptosForm.AttachBrowser();
        }

        private void btnCryptos_Leave(object sender, EventArgs e)
        {
            btnCryptos.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnPortfolio_Click(object sender, EventArgs e)
        {
            btnSelected(btnPortfolio, panelNav);

            OpenChildForm(PortfolioForm);
        }

        private void btnPortfolio_Leave(object sender, EventArgs e)
        {
            btnPortfolio.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnComponent_Click(object sender, EventArgs e)
        {
            btnSelected(btnComponent, panelNav);

            OpenChildForm(ComponentForm);

            ComponentForm.AttachBrowser();

            CEFSharpController.LoadNewUrl(CurrentDirectoryPath + "\\chartHtmls\\BTCKRW.html");
        }

        private void btnComponent_Leave(object sender, EventArgs e)
        {
            btnComponent.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMainFormClose_Click(object sender, EventArgs e)
        {
            // MainForm 종료시 실행되고 있는 모든 쓰레드를 Abort를 실행해
            // ThreadAbortException 예외를 발생시킨 후 무한 루프를 빠져나오게 합니다.

            FormThreadPool.KillThreadAll();

            Application.Exit();
        }

        private void btnMainFormMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
