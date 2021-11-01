using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{

    // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
    //
    // DataSettings.cs에 있는 경로에 있는 Python 스크립트를 실행하기 위한
    // 클래스 입니다.
    // 
    // IronPython은 Python2.7을 기반으로하여 현재 여러 문법이 Python3.9 버전의
    // 문법과 다른 부분이 있어 터미널에서 실행하는 프로세스를 만들어 스크립트를 실행할 시
    // 출력되는 문장을 기반으로한 반환값으로 가지도록 설계하였습니다.
    // 
    // 만약 requests, cryptocompare 패키지가 설치되어 있지 않으시면
    // =================
    //    pip install requests
    //    pip install cryptocompare
    // =================
    // 명령을 실행해 패키지를 설치해주세요.
    // 
    // Python.exe 경로와 스크립트의 경로는 DataSettings.cs에서 설정하실 수 있습니다.
    //
    // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

    class Executors
    {

        // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
        //
        // CryptoForm의 쓰레드에서 실행되는 Executor입니다.
        //
        // 실행되는 주기는 DataSettings.cs의 CRYPTO_PRICE_LOADER_TICK를 통하여
        // 주기를 설정할 수 있습니다.(기준은 millisecond가 아닌 second입니다.)
        // 
        // 반환되는 값은 DataManager.cs의 CryptoFormsPythonScriptExecutorResult에
        // 바로 저장됩니다.
        // 
        // 이 Executor은 Binance 거래소에서는 주요 가상화폐(시가 총액이 높은 순으로) 
        // Bitcoin(BTC), Ethereum(ETH), Ada Cardno(ADA), Ripple(XRP)의
        // USDT(USD Tether: USA Dollar와 1:1 대응되는 토큰) 현재 가격과 오픈 가격을
        // 가져오며, Upbit 거래소에서는 Bitcoin과 추가로 CryptosForm에서 검색한
        // 가상화폐의 가격, 환율 정보를 가져옵니다.
        //
        // 추가로 검색한 가상화폐는 실행 인자로 넘어갑니다. (예: -SOL)
        //
        // =========================================
        // 실행 예시:
        // python get_top_coin_trade_price.py -SOL
        //
        // 결과:
        // BTCF=72600000 exchange=1178.5 SOLU=240900.0 BTC=60907.0 BTCOPEN=60617.0 \
        // ETH=4292.3 ETHOPEN=4240.3 XRP=1.084 XRPOPEN=1.095 ADA=1.949 \
        // ADAOPEN=1.951 SOL=202.15 SOLOPEN=195.82
        //=========================================
        // 
        // BTCF: Upbit Bitcoin 현재 가격
        // SOLU: 인자로 넘겨진 검색된 가상화폐 Solana(SOL) UPbit 현재 가격
        // excnahge: 환율
        // BTC: Binance Bitcoin 현재 가격
        // BTCOPEN: Binance Bitcoin 오픈 가격(일, Day)
        // ETH, ADA, XRP 모두 동일합니다.
        // SOL: 인자로 넘겨진 검색된 가상화폐의 BInance 가격
        //
        // CryptoFormsExecutePythonScript의 반환 값은 위의 결과를 Dictionary<string, string>로
        // 변환하여 반환합니다.
        //
        // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

        public static Dictionary<string, string> CryptoFormsExecutePythonScript(string ProcessArguments, string ProcessFileName, string ArgumentOption)
        {
            var psi = new ProcessStartInfo
            {
                Arguments = ProcessArguments + ArgumentOption,
                FileName = ProcessFileName,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true // 참이지만 프로세스에서 에러시 스크립트로 직접 확인해보시는게 편합니다.
            };
            var results = "";

            using (var process = Process.Start(psi))
            {
                results = process.StandardOutput.ReadToEnd().Trim();
            }

            return results.Split(' ')
                             .Select(part => part.Split('='))
                             .Where(part => part.Length == 2)
                             .ToDictionary(sp => sp[0], sp => sp[1]);
        }

        // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
        //
        // MainForm의 쓰레드에서 실행되는 Executor입니다.
        //
        // 실행되는 주기는 DataSettings.cs의 PORTFOLIO_LOADER_TICK 통하여
        // 주기를 설정할 수 있습니다.(기준은 millisecond가 아닌 second입니다.)
        // 
        // 반환되는 값은 DataManager.cs의 UpbitPortfolioPythonScriptExecutorResult에
        // 바로 저장됩니다.
        // 
        // 이 Executor은 업비트 거래소의 포트폴리오에 대한 정보를 가져옵니다.
        //
        // 실행인자는 없습니다.
        //
        // =========================================
        // 실행 예시:
        // python upbit.py
        //
        // 결과(이전의 Executor과 비슷하지만 편의를 위해 스크립트 내부의 결과 확인용으로 출력하였습니다.):
        //                     BID         BALANCE        QUOTE        AMOUNT     EVAL_AMOUNT       RETURN    MARGIN     WEIGHT
        // MASK    16007.728      30.84348733    13177.867           493734                406451       -87283       -17.68       58.20
        // KRW            0                  354277                0                  0                        0              0            0          41.80
        // TOTAL          0                 760728                0           493734                406451       -87283       -17.68        58.22
        //=========================================
        // 
        // BID: 평균 매수가
        // BALANCE: 보유 수량
        // QUOTE: 현재가
        // AMOUNT: 매수 금액
        // EVAL_AMOUNT: 평가 금액
        // RETURN: 손익
        // MARGIN: 수익률
        // WEIGHT: 포트폴리오 내 비중
        //
        // MainFormsExecutePythonsScript 반환 값은 위의 결과를 List<Dictionary<string, string>>로
        // 변환하여 반환합니다.
        //
        // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

        public static List<Dictionary<string, string>> MainFormsExecutePythonsScript(string ProcessArguments, string ProcessFileName)
        {
            Dictionary<string, string> symbolDictionary = new Dictionary<string, string>();
            List<Dictionary<string, string>> portfolio = new List<Dictionary<string, string>>();

            var psi = new ProcessStartInfo
            {
                Arguments = ProcessArguments,
                FileName = ProcessFileName,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            var results = "";

            using (var process = Process.Start(psi))
            {
                results = process.StandardOutput.ReadToEnd().Trim();
            }

            string[] temp = results.Split(' ');

            foreach (string symbol in temp)
            {
                symbolDictionary = symbol.Split(',').Select(part => part.Split('='))
                                                            .Where(part => part.Length == 2)
                                                            .ToDictionary(sp => sp[0], sp => sp[1]);

                portfolio.Add(symbolDictionary);
            }

            return portfolio;
        }
    }
}
