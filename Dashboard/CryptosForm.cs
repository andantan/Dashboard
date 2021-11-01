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
using System.Threading;

using static Dashboard.DataSettings;

namespace Dashboard
{
    public partial class CryptosForm : Form
    {
        readonly private static string[] DefaultChart = { "BTC", "KRW" };

        private string SearchSymbol;
        private string time;

        private static List<Ticker> gridDatas = new List<Ticker>();

        public CryptosForm()
        {
            InitializeComponent();
        }

        private void CryptosForm_Load(object sender, EventArgs e)
        {
            SearchSymbol = textBoxSearchCoinSymbol.Text;

            AttachBrowser();

            labelCurrentChart.Text = string.Join("-", DefaultChart);

            dataGridViewPairs.DataSource = (from ticker in DataManager.pairs
                                            where ticker.Symbol == DefaultChart[0]
                                            select ticker).ToList<Ticker>();

            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // Executors.cs의 CryptoFormsExecutePythonScript을 실행하기 위한 쓰레드를
            // 생성 및 실행합니다.
            //
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

            Thread LoadPriceToForm = new Thread(new ThreadStart(LoadPriceByCryptoComparePackage))
            {
                IsBackground = true
            };

            FormThreadPool.AddThreadToPool(LoadPriceToForm);

            LoadPriceToForm.Start();
        }

        public void AttachBrowser() // detour
        {
            CEFSharpController.AttachBrowser(panelMainWebViewerByCefSharp);
        }

        private void LoadPriceByCryptoComparePackage()
        {

            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // 이 설명을 읽기 전에 Executors.cs 소스 내부의 설명을 먼저 읽고 오시면은
            // 더욱 이해하기 수월합니다.
            //
            // 이 쓰레드 전용 메소드는 주요 가상화페의 가격과 검색한 가상화페의 가격
            // , 오픈 가격, 환율에 대한 정보를 가져옵니다.
            //
            // 정해진 주기마다 Executors.cs의 CryptoFormsExecutePythonScript 실행한 후 
            // DataManager의 CryptoFormsPythonScriptExecutorResult 저장합니다.
            //
            // 후에 관련 데이터를 표현하는 레이블과 차트 등을 설정합니다.
            //
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

            while (true)
            {
                try
                {
                    if (DateTime.Now.Second % CRYPTO_PRICE_LOADER_TICK == 0)
                    {
                        time = DateTime.Now.ToString();

                        DataManager.CryptoFormsPythonScriptExecutorResult = Executors.CryptoFormsExecutePythonScript(PyCPCYPath, PythonPath, " -" + SearchSymbol);

                        Invoke(new Action(() => PriceAndPremiumSetter(time)));
                    }
                }
                catch (ThreadAbortException)
                {
                    break;
                }
            }
        }

        private void PriceAndPremiumSetter(string datetime)
        {
            // DataManager의 CryptoFormsPythonScriptExecutorResult에 저장된 정보를 폼에 나타냅니다.
            try
            {
                labelLoadTime.Text = "로드 시각: " + datetime;

                double BTCPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["BTC"]);
                double ETHPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["ETH"]);
                double XRPPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["XRP"]);
                double ADAPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["ADA"]);

                double BTCOpenPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["BTCOPEN"]);
                double ETHOpenPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["ETHOPEN"]);
                double XRPOpenPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["XRPOPEN"]);
                double ADAOpenPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["ADAOPEN"]);

                double exchange = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["exchange"]);
                double KRWPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult[SearchSymbol + "U"]);

                Invoke(new Action(() =>
                {
                    PriceLabelSetter(labelBTCUSDT, labelShowBTCPrice, "BTCUSDT", BTCPrice - BTCOpenPrice);
                    PriceLabelSetter(labelETHUSDT, labelShowETHPrice, "ETHUSDT", ETHPrice - ETHOpenPrice);
                    PriceLabelSetter(labelXRPUSDT, labelShowXRPPrice, "XRPUSDT", XRPPrice - XRPOpenPrice);
                    PriceLabelSetter(labelADAUSDT, labelShowADAPrice, "ADAUSDT", ADAPrice - ADAOpenPrice);
                }));

                labelShowBTCPrice.Text = BTCPrice.ToString() + " USDT";
                labelShowETHPrice.Text = ETHPrice.ToString() + " USDT";
                labelShowXRPPrice.Text = XRPPrice.ToString() + " USDT";
                labelShowADAPrice.Text = ADAPrice.ToString() + " USDT";

                if (DataManager.pairs.Exists((x) => x.Symbol.Equals(SearchSymbol) && x.Market.Equals("USDT")))
                {
                    double ExchangedKRWPrice;
                    double Difference;

                    double USDTPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult[SearchSymbol]);

                    ExchangedKRWPrice = USDTPrice * exchange;
                    Difference = KRWPrice - ExchangedKRWPrice;

                    labelUSDTPriceOfSelectedSymbol.Text = USDTPrice.ToString() + " USDT";

                    if (SearchSymbol.Equals("XEC"))
                    {
                        labelExchangedKRWPrice.Text = Math.Round(ExchangedKRWPrice, 3).ToString() + " KRW";
                        labelDifferencePrice.Text = Math.Round(Difference, 3).ToString() + " KRW";
                    }
                    else if (SearchSymbol.Equals("BTT"))
                    {
                        labelExchangedKRWPrice.Text = Math.Round(ExchangedKRWPrice, 2).ToString() + " KRW";
                        labelDifferencePrice.Text = Math.Round(Difference, 2).ToString() + " KRW";
                    }
                    else
                    {
                        labelExchangedKRWPrice.Text = Math.Round(ExchangedKRWPrice, 1).ToString() + " KRW";
                        labelDifferencePrice.Text = Math.Round(Difference, 1).ToString() + " KRW";
                    }

                    // 김치 프리미엄은 해외 거래소와의 괴리율이 발생해 나타나는 가격 차이를
                    // 백분율로 나타낸 지표를 의미합니다.

                    labelKimchiPremium.Text = Math.Round((Difference / ExchangedKRWPrice) * 100, 1).ToString() + "%";

                    if (Difference < 0)
                    {
                        labelDifferencePrice.ForeColor = Color.FromArgb(128, 128, 255);
                        labelKimchiPremium.ForeColor = Color.FromArgb(128, 128, 255);
                    }
                    else if (0 < Difference)
                    {
                        labelDifferencePrice.ForeColor = Color.FromArgb(255, 128, 128);
                        labelKimchiPremium.ForeColor = Color.FromArgb(255, 128, 128);
                    }
                    else
                    {
                        labelDifferencePrice.ForeColor = Color.FromArgb(195, 183, 183);
                        labelKimchiPremium.ForeColor = Color.FromArgb(195, 183, 183);
                    }
                }
                else
                {
                    // 김치코인은 전세계 1위 거래량을 보유한 거래소인 Binance의 USDT 마켓에
                    // 상장되어있지 않고 업비트에만 상장된 가상화폐를 의미합니다.

                    labelUSDTPriceOfSelectedSymbol.Text = "KIMCHI COIN";
                    labelExchangedKRWPrice.Text = "KIMCHI COIN";
                    labelDifferencePrice.Text = "KIMCHI COIN";
                    labelKimchiPremium.Text = "KIMCHI COIN";
                }

                labelKRWPriceOfSelctedSymbol.Text = KRWPrice.ToString() + " KRW";
                labelExchangeKRWToDollar.Text = exchange.ToString() + " KRW";
            }
            catch (Exception)
            {
                // ignore
            }
        }

        private void PriceLabelSetter(Label labelOpenPrice, Label labelTradePrice, string labelNameOpenPrice, double difference)
        {
            if (difference < 0)
            {
                labelOpenPrice.Text = labelNameOpenPrice + " ▼";

                labelOpenPrice.ForeColor = Color.FromArgb(128, 128, 255);
                labelTradePrice.ForeColor = Color.FromArgb(128, 128, 255);
            }
            else if (0 < difference)
            {
                labelOpenPrice.Text = labelNameOpenPrice + " ▲";

                labelOpenPrice.ForeColor = Color.FromArgb(255, 128, 128);
                labelTradePrice.ForeColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                labelOpenPrice.Text = labelNameOpenPrice + "-";

                labelOpenPrice.ForeColor = Color.FromArgb(195, 183, 183);
                labelTradePrice.ForeColor = Color.FromArgb(195, 183, 183);
            }
        }

        private void btnSearchCoin_Click(object sender, EventArgs e)
        {
            // 검색하고자 하는 가상화폐의 심볼을 입력하면 Executors.cs의 CryptoFormsExecutePythonScript의
            // 실행 인자로 입력되게 합니다.
            // 또한, 해당 가상화폐와 연결된 마켓을 표현해줍니다.
            // 검색한 가상화폐의 기본 마켓(KRW) 또는 김치코인이면 BTC마켓의 차트를 띄어줍니다.
            // 마켓은 USDT, KRW, USD, BTC 4개의 마켓으로 한정했습니다.

            SearchSymbol = textBoxSearchCoinSymbol.Text.ToUpper();

            if (SearchSymbol != "")
            {
                gridDatas = (from ticker in DataManager.pairs
                             where ticker.Symbol == SearchSymbol.ToUpper()
                             select ticker).ToList<Ticker>();

                if (gridDatas.Count == 0) MessageBox.Show("Symbol does not STOCKED");
                else
                {
                    dataGridViewPairs.DataSource = null;
                    dataGridViewPairs.DataSource = gridDatas;

                    string htmlPath = Directory.GetCurrentDirectory() + "\\chartHtmls\\" + SearchSymbol +  "KRW.html";

                    try
                    {
                        CEFSharpController.LoadNewUrl(htmlPath);

                        labelCurrentChart.Text = SearchSymbol + "-KRW";
                    }
                    catch
                    {
                        htmlPath = Directory.GetCurrentDirectory() + "\\chartHtmls\\" + SearchSymbol + "BTC.html";

                        labelCurrentChart.Text = SearchSymbol + "-BTC";

                        CEFSharpController.LoadNewUrl(htmlPath);
                    }
                }
            }
        }

        private void dataGridViewPairs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 마켓을 더블클릭하면 해당 심볼과 마켓에 대한 차트를 보여줍니다
            // 예: BTC-USDT, ADA-KRW, DOT-BTC, XEC-KRW...
            try
            {
                Ticker selectedTicker = dataGridViewPairs.CurrentRow.DataBoundItem as Ticker;

                string htmlPath = Directory.GetCurrentDirectory() + "\\chartHtmls\\" + selectedTicker.Symbol + selectedTicker.Market + ".html";

                labelCurrentChart.Text = selectedTicker.Symbol + "-" + selectedTicker.Market;

                CEFSharpController.LoadNewUrl(htmlPath);
            }
            catch (Exception ERO)
            {
                MessageBox.Show("Error occured: " + ERO.Message + " - " + ERO.Source);
            }
        }

        private void CryptosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 패널에 부착된 브라우저를 제거합니다.

            CEFSharpController.DetachBrowser(panelMainWebViewerByCefSharp);
        }
    }
}
