using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Dashboard.DataSettings;

namespace Dashboard
{
    // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
    //
    // 교수님! Path 변수의 설정을 꼭 확인해주세요!!
    //
    // MainForm, CryptosForm, PortfolioForm, ComponentForm 총 4개의 폼에서
    // 전역으로 사용되는 중요한 데이터들이지만 환경에 맞춰서 바꿔야하는 변수들을
    // 모아둔 클래스입니다.
    //
    // CurrentDirectoryPath은 현재 솔루션이 실행되는 디렉토리의 경로를 얻는 변수이며
    // Python으로 시작되는 변수는 파이썬을 실행하기 위한 경로를 담은 변수입니다.
    //
    // TICK으로 끝나는 변수는 쓰레드의 실행주기입니다.
    //
    // CRYPTO_PRICE_LOADER_TICK은 CryptosForm의 LoadPriceToForm 쓰레드의 실행 주기를
    // 정하는 변수입니다. (15를 권장합니다. 만일 속도가 저하되면 20을 권장드립니다.)
    //
    // PORTFOLIO_LOADER_TICK은 MainForm의 LoadPortfolio 쓰레드의 실행 주기를 정하는
    // 변수입니다. (10을 권장합니다. 만일 속도가 저하되거나 폼에 표현되는 데이터를 자세하게
    // 보고싶으시면 30을 권장드립니다.)
    // 
    // Criteria는 PortfolioForm에서 PieChart에 표현되는 비중 중 어느 기준 아래의 비중이면
    // Etc.. 에 포함되게 하는 변수입니다. 
    // 예를 들면 Criteria가 3일 때, BTC 비중 40%, SOL 비중 1.1%, TT 비중 1.4%, DOT 2.8%로
    // 포트폴리오가 구성되면 Etc..는 5.3%(1.1% + 1.4% + 2.8%)로 표시됩니다.
    //
    // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

    class DataSettings
    {
        readonly public static string CurrentDirectoryPath = System.IO.Directory.GetCurrentDirectory();

        // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+
        // 
        // 교수님! 번거로우시겠지만은 파이썬 스크립트 실행을 위한 경로 파악을 위해서
        // 확인해 주셔야할 것이 있습니다.
        //
        // 먼저 터미널에서 다음 명령어로 파이썬 실행 경로를 파악해주세요.
        // ================
        //    python
        //    >>> import sys
        //    >>> sys.executable
        //
        // 결과:
        //    C:\\Users\\전규빈\\AppData\\Local\\Programs\\Python\\Python{버전}\\python.exe
        // ================
        // 이 때, 경로 내에 "전규빈" 처럼 한글이 포함되어있으시면 프로세스가 실행이 안됩니다.
        //
        // 한글이 없으시면 PythonPath 변수에 결과 그대로를 복사해서 붙여넣어주세요.
        // 또한, PyUpbitPath 변수를 
        // CurrentDirectoryPath + "\\scripts\\upbit.py"
        // 로 바꿔주시면 됩니다.
        // 마지막으로, PyCPCYPath 변수를
        // CurrentDirectoryPath + "\\scripts\\get_top_coin_trade_price.py"
        // 로 바꿔주시면 됩니다.
        //
        // 만일 한글이 있으시면 파일탐색기에서 <보기>를 클릭하신 후 숨긴 항목을 체크하신 후
        // 결과의 경로를 따라 Programs 바로 밑에있는 Python 폴더 자체를 복사하신 후에
        // C 드라이브에 "TempStorage" 폴더를 생성하신 후 폴더 내에 붙여넣기 해주세요.
        // 붙여넣기가 완료되셨으면 PythonPath 변수를 
        // @"C:\TempStorage\Python\Python{버전}\python.exe"
        // 로 바꾸어주시면 됩니다.
        // 또한 Debug 폴더 내부에 있는 scripts 폴더를 C 드라이브의 TempStorage 내부로 옮겨주세요.
        // 모두 옮기셨으면 PyUpbitPath 변수를
        // @"C:\TempStorage\scripts\upbit.py";
        // 로 바꿔주시면 됩니다.
        // 마지막으로, PyCPCYPath 변수를 
        // @"C:\TempStorage\scripts\get_top_coin_trade_price.py";
        // 로 바꿔주시면 변수 설정은 모두 끝납니다.
        //
        // +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-++-+

        // readonly public static string PythonPath = @"C:\\Users\\전규빈\\AppData\\Local\\Programs\\Python\\Python{버전}\\python.exe";
        // readonly public static string PyUpbitPath = CurrentDirectoryPath + "\\scripts\\upbit.py"
        // readonly public static string PyCPCYPath = CurrentDirectoryPath + "\\scripts\\get_top_coin_trade_price.py"

        readonly public static string PythonPath = @"C:\TempStorage\Python\Python38\python.exe";
        readonly public static string PyUpbitPath = @"C:\TempStorage\scripts\upbit.py";
        readonly public static string PyCPCYPath = @"C:\TempStorage\scripts\get_top_coin_trade_price.py";

        readonly public static int CRYPTO_PRICE_LOADER_TICK = 15;
        readonly public static int PORTFOLIO_LOADER_TICK = 10;

        readonly public static double Criteria = 3.0;
    }
}
