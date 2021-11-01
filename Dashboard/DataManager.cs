using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;
using System.IO;

namespace Dashboard
{
    class DataManager
    {
        public static int howManyCoinsDoYouHave = 0;

        public static List<Ticker> pairs = new List<Ticker>();
        public static List<Coin> portfolio = new List<Coin>();
        public static List<OwnCoins> ownCoins = new List<OwnCoins>();

        public static Dictionary<string, string> CryptoFormsPythonScriptExecutorResult = new Dictionary<string, string>();

        public static List<Dictionary<string, string>> UpbitPortfolioPythonScriptExecutorResult = new List<Dictionary<string, string>>();

        static DataManager()
        {
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
            //
            // pair.xml 에는 Upbit 거래소에 상장된 가상화폐를 기준으로 Binance 거래소의
            // USDT, BTC, USD 중 존재하는(페어된) 마켓에 관한 정보를 가지고있습니다.
            //
            // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

            string PairXML = File.ReadAllText(@"./pair.xml");

            XElement PairXElement = XElement.Parse(PairXML);

            pairs = (from element in PairXElement.Descendants("ticker")
                     select new Ticker()
                     {
                         Symbol = element.Element("symbol").Value,
                         Market = element.Element("market").Value
                     }).ToList<Ticker>();
        }

        public static void SetPortfolioFormDataGridDataSource()
        {
            // PortfolioForm과 ComponentForm의 데이터그리드뷰의 데이터소스를 생성해줍니다.

            portfolio = (from coin in UpbitPortfolioPythonScriptExecutorResult
                         where !(coin["SYMBOL"].Equals("KRW") || coin["SYMBOL"].Equals("TOTAL"))
                         orderby double.Parse(coin["AMOUNT"]) descending
                         select new Coin()
                         {
                             Symbol = coin["SYMBOL"],
                             Bid = coin["BID"],
                             Balance = coin["BALANCE"],
                             Quote = coin["QUOTE"],
                             Amount = coin["AMOUNT"],
                             Eval_amount = coin["EVAL_AMOUNT"],
                             Return = coin["RETURN"],
                             Margin = coin["MARGIN"] + "%",
                             Weight = coin["WEIGHT"] + "%"
                         }).ToList<Coin>();
        }

        public static void SetComponentFormDataGridSource()
        {
            // ComponentForm의 데이터그리드뷰의 데이터 소스를 생성해줍니다.

            ownCoins = (from coin in UpbitPortfolioPythonScriptExecutorResult
                        where !(coin["SYMBOL"].Equals("KRW") || coin["SYMBOL"].Equals("TOTAL"))
                        orderby double.Parse(coin["AMOUNT"]) descending
                        select new OwnCoins()
                        {
                            Symbol = coin["SYMBOL"]
                        }).ToList<OwnCoins>();
        }
    }
}
