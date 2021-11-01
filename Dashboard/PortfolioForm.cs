using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Dashboard.DataSettings;

namespace Dashboard
{
    public partial class PortfolioForm : Form
    {
        readonly public static string defaultSymbol = "TOTAL";

        private Dictionary<string, string> defaultDictionary;
        private Dictionary<string, string> cashDictionary;

        public PortfolioForm()
        {
            InitializeComponent();

            ChartPortfolioComponent.Series["Component"].IsValueShownAsLabel = true;
            ChartPortfolioComponent.Series["Component"].Label = "#PERCENT{0.00 %}";
            ChartPortfolioComponent.Series["Component"].LegendText = "#VALX";

            ChartPortfolioComponent.Series["Component"].Points.AddXY("LOADING", "25");
            ChartPortfolioComponent.Series["Component"].Points.AddXY("LOADING", "25");
            ChartPortfolioComponent.Series["Component"].Points.AddXY("LOADING", "25");
            ChartPortfolioComponent.Series["Component"].Points.AddXY("LOADING", "25");
        }

        public void ComponentPieChartSetter()
        {
            // DataManager의 UpbitPortfolioPythonScriptExecutorResult에 저장된 포트폴리오의
            // 보유한 가상화폐의 매수 가격을 기준으로 비중을 파이차트로 표시합니다.

            ChartPortfolioComponent.Series["Component"].Points.Clear();

            try
            {
                double EGs = 0;

                foreach (Dictionary<string, string> component in DataManager.UpbitPortfolioPythonScriptExecutorResult)
                {
                    if (component["SYMBOL"] != "TOTAL")
                    {
                        ++DataManager.howManyCoinsDoYouHave;

                        if (double.Parse(component["WEIGHT"]) < Criteria)
                            EGs += double.Parse(component["WEIGHT"]);
                        else
                            ChartPortfolioComponent.Series["Component"].Points.AddXY(component["SYMBOL"], component["WEIGHT"]);
                    }
                }

                if (EGs != 0)
                    ChartPortfolioComponent.Series["Component"].Points.AddXY("etc..", EGs.ToString());
            }
            catch (Exception)
            {
                // ignore
            }
        }

        public void PortfolioLabelDataSetter(string datetime)
        {
            // DataManager의 UpbitPortfolioPythonScriptExecutorResult에 저장된 정보를 폼에 나타냅니다.

            dataGridViewCoins.DataSource = null;
            dataGridViewCoins.DataSource = DataManager.portfolio;

            defaultDictionary = DataManager.UpbitPortfolioPythonScriptExecutorResult.Single((x) => x["SYMBOL"] == "TOTAL");
            cashDictionary = DataManager.UpbitPortfolioPythonScriptExecutorResult.Single((x) => x["SYMBOL"] == "KRW");

            labelLoadTime.Text = "로드 시각: " + datetime;

            double TotalReturn = double.Parse(defaultDictionary["RETURN"]);
            double ReturnAverage = double.Parse(defaultDictionary["MARGIN"]);

            labelKRWBalance.Text = cashDictionary["BALANCE"] + " KRW";

            labelTotalAsset.Text = defaultDictionary["BALANCE"] + " KRW";
            labelTotalBidWeight.Text = defaultDictionary["WEIGHT"] + "%";
            labelTotalBlendedPrice.Text = defaultDictionary["AMOUNT"] + " KRW";
            labelTotalMarketPrice.Text = defaultDictionary["EVAL_AMOUNT"] + " KRW";
            labelTotalReturn.Text = TotalReturn.ToString() + " KRW";
            labelReturnAverage.Text = ReturnAverage.ToString() + "%";

            if (TotalReturn < 0)
            {
                labelTotalReturn.ForeColor = Color.FromArgb(128, 128, 255);
                labelReturnAverage.ForeColor = Color.FromArgb(128, 128, 255);
            }
            else if (0 < TotalReturn)
            {
                labelTotalReturn.ForeColor = Color.FromArgb(255, 128, 128);
                labelReturnAverage.ForeColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                labelTotalReturn.ForeColor = Color.FromArgb(195, 183, 183);
                labelReturnAverage.ForeColor = Color.FromArgb(195, 183, 183);
            }
        }
    }
}
