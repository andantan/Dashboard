using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class ComponentForm : Form
    {
        public string Salt = ".";

        public ComponentForm()
        {
            InitializeComponent();
        }

        private void ComponentForm_Load(object sender, EventArgs e)
        {
            AttachBrowser();
        }

        public void AttachBrowser() // detour
        {
            CEFSharpController.AttachBrowser(panelMainWebViewerByCefSharp);
        }

        public void DataGridViewSetter()
        {
            if (dataGridViewOwnCoins.DataSource != null)
                dataGridViewOwnCoins.DataSource = null;

            if (DataManager.howManyCoinsDoYouHave != 0)
                dataGridViewOwnCoins.DataSource = DataManager.ownCoins;
            else
                Salt = ".";
        }

        public void PriceAndPremiumSetter(bool threadCalled, string datetime="")
        {
            // DataManager의 UpbitPortfolioPythonScriptExecutorResult에 저장된 정보를 폼에 나타냅니다.

            if (threadCalled)
                labelLoadTime.Text = datetime;

            if (!Salt.Equals("."))
            {
                try
                {
                    Coin coin = DataManager.portfolio.Single<Coin>((x) => x.Symbol.Equals(Salt));

                    double Return = double.Parse(coin.Return);
                    double Margin = double.Parse(coin.Margin.Replace("%", ""));

                    double exchange = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["exchange"]);
                    double btcUSDTPrice = double.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["BTC"]);
                    int btcKRWPrice = int.Parse(DataManager.CryptoFormsPythonScriptExecutorResult["BTCF"]);

                    double exchangedKRWPrice = btcUSDTPrice * exchange;
                    double difference = btcKRWPrice - exchangedKRWPrice;

                    labelKimchiPremium.Text = "(BTC) " + Math.Round((difference / exchangedKRWPrice) * 100, 1).ToString() + "%";

                    if (difference < 0) labelKimchiPremium.ForeColor = Color.FromArgb(128, 128, 255);
                    else if (0 < difference) labelKimchiPremium.ForeColor = Color.FromArgb(255, 128, 128);
                    else labelKimchiPremium.ForeColor = Color.FromArgb(195, 183, 183);

                    labelAmount.Text = coin.Amount.ToString();
                    labelEvalAmount.Text = coin.Eval_amount.ToString();

                    if (Salt.Equals("XEC"))
                    {
                        labelBid.Text = coin.Bid.ToString();
                        labelQuote.Text = coin.Quote.ToString();
                    }
                    else if (Salt.Equals("BTT"))
                    {
                        labelBid.Text = Math.Round(double.Parse(coin.Bid), 2).ToString();
                        labelQuote.Text = Math.Round(double.Parse(coin.Quote), 2).ToString();
                    }
                    else
                    {
                        labelBid.Text = Math.Round(double.Parse(coin.Bid), 1).ToString();
                        labelQuote.Text = Math.Round(double.Parse(coin.Quote), 1).ToString();
                    }

                    labelBalance.Text = coin.Balance.ToString();
                    labelWeight.Text = coin.Weight.ToString();
                    labelReturn.Text = Return.ToString();
                    labelMargin.Text = Margin.ToString() + "%";

                    if (Return < 0)
                    {
                        labelReturn.ForeColor = Color.FromArgb(128, 128, 255);
                        labelMargin.ForeColor = Color.FromArgb(128, 128, 255);
                    }
                    else if (0 < Return)
                    {
                        labelReturn.ForeColor = Color.FromArgb(255, 128, 128);
                        labelMargin.ForeColor = Color.FromArgb(255, 128, 128);
                    }
                    else
                    {
                        labelReturn.ForeColor = Color.FromArgb(195, 183, 183);
                        labelMargin.ForeColor = Color.FromArgb(195, 183, 183);
                    }
                }
                catch (Exception)
                {
                    labelAmount.Text = "     - -- -     ";
                    labelEvalAmount.Text = "     - -- -     ";
                    labelBid.Text = "     - -- -     ";
                    labelQuote.Text = "     - -- -     ";
                    labelBalance.Text = "     - -- -     ";
                    labelWeight.Text = "     - -- -     ";
                    labelReturn.Text = "     - -- -     ";
                    labelMargin.Text = "   - -- -     ";
                }
            }
            else
            {
                labelAmount.Text = "     - -- -     ";
                labelEvalAmount.Text = "     - -- -     ";
                labelBid.Text = "     - -- -     ";
                labelQuote.Text = "     - -- -     ";
                labelBalance.Text = "     - -- -     ";
                labelWeight.Text = "     - -- -     ";
                labelReturn.Text = "     - -- -     ";
                labelMargin.Text = "   - -- -     ";
            }
        }

        private void ComponentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CEFSharpController.DetachBrowser(panelMainWebViewerByCefSharp);
        }

        private void dataGridViewOwnCoins_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 보유한 가상화폐 중 하나를 더블클릭하면 이와 연결된 마켓페어를 보여줍니다.

            OwnCoins selectedSymbol = dataGridViewOwnCoins.CurrentRow.DataBoundItem as OwnCoins;
            Salt = selectedSymbol.Symbol;

            if (dataGridViewOwnCoinPairs.DataSource != null)
                dataGridViewOwnCoinPairs.DataSource = null;

            dataGridViewOwnCoinPairs.DataSource = (from ticker in DataManager.pairs
                                                   where ticker.Symbol.Equals(selectedSymbol.Symbol)
                                                   select ticker).ToList<Ticker>();

            PriceAndPremiumSetter(false);
        }

        private void dataGridViewOwnCoinPairs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 마켓페어를 더블클릭하면 이에 해당하는 차트를 띄어줍니다.
            try
            {
                Ticker selectedTicker = dataGridViewOwnCoinPairs.CurrentRow.DataBoundItem as Ticker;

                string htmlPath = Directory.GetCurrentDirectory() + "\\chartHtmls\\" + selectedTicker.Symbol + selectedTicker.Market + ".html";

                labelCurrentChart.Text = selectedTicker.Symbol + "-" + selectedTicker.Market;

                CEFSharpController.LoadNewUrl(htmlPath);
            }
            catch (Exception ERO)
            {
                MessageBox.Show("Error occured: " + ERO.Message + " - " + ERO.Source);
            }
        }
    }
}
