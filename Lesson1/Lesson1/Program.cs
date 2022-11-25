using System;
using System.Runtime.CompilerServices;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertRoomSize();
        }

        //! 프로그래밍이란 무엇인지 용어와 함께 소개한다.
        public static void WhatIsProgramming()
        {
            /**
             * 컴퓨터는 하드웨어(Hardware)와 소프트웨어(Software)로 구성된다. 하드웨어는 PC, 스마트폰과 같은
             * 물리적으로 존재하는 장치를 의미한다. 소프트웨어는 이러한 하드웨어에 설치된 운영체제, 앱 등을 의미한다.
             * 
             * 프로그램(Program)이란 우리가 하고자하는 작업을 컴퓨터에게 전달하여 주는 역할을 하는 소프트웨어를 
             * 의미한다.
             * 프로그램 안에는 "무엇을 어떤 식으로 해라" 와 같은 형태의 명령어(Instruction) 들이 들어 있다.
             * 
             * 소프트웨어를 만드는 행위를 프로그래밍(Programming) 또는 코딩(Coding)이라고 한다.
             * 
             * 컴퓨터가 알아듣는 언어는 한가지 뿐이다. 
             * 0과 1의 형태로 구성되어 있으며 기계어(Machine language)라고 부른다.
             * 과거 초기 형태의 컴퓨터는 이러한 기계어를 사용하여 프로그래밍 했었다.
             * 기계어는 인간에게 상당히 불편한 언어기 때문에 사람이 이해하기 쉬운 프로그래밍 언어가 만들어지게 된다.
             * 프로그래밍 언어의 예약어(Keyward)와 문법으로 소프트웨어를 만드는 사람을 프로그래머(Programmer) 또는
             * 개발자(Developer)라고 한다.
             * 
             * 프로그래밍 언어의 문법에 맞게 작성한, 텍스트로 된 명령 집합을 코드(Code) 또는 소스(Source)라고 한다.
             * 소스코드를 기계어로 번역하는 작업을 컴파일(Compile)이라고 한다. 이러한 작업을 하는 소프트웨어를 
             * 컴파일러(Compiler)라고 한다.
             * 
             * 프로그래밍을 하는 과정은 다음과 같다.
             * 1. 텍스트 에디터로 소스를 작성하여 파일로 저장한다.       ex) .cs 파일
             * 2. 소스 파일을 컴파일하여 실행 프로그램을 생성한다.       ex) .exe 파일
             * 3. 프로그램을 실행한다.
             * 이 중 1, 2 단계를 합쳐서 흔히 빌드(Build)라고 한다.
             * 
             * 프로그래밍 과정 중 발생한 오류를 버그(Bug)라고 한다.
             * 오류를 탐색하고 수정하는 과정을 디버그(Debug) 또는 디버깅(Debugging)이라고 한다.
             */
        }

        //! C#은 어떤 특성을 가지는지 용어와 함께 소개한다.
        public static void WhatIsCSharp()
        {
            /**
             * C#의 특징
             * C#은 .Net(닷넷)을 위한 많은 언어 중 하나로, 마이크로소프트의 닷넷 플랫폼을 기반으로 한다.
             * 절차적 언어와 객체지향적 언어의 특징, 그리고 함수형 프로그래밍 스타일을 제공하는 다중 패러다임
             * 프로그래밍 언어이다.
             * C#은 C, C++, Java, Javascript와 기초 문법이 비슷하다.
             * C#은 자동으로 메모리를 관리한다. (Garbage collection 기능을 제공)
             * C#은 컴파일 기반 언어이다.
             * C#은 C나 Javascript와 달리 전역함수나 전역변수가 없고, 모두 클래스 안에서 생성된다.
             * C#은 강력한 형식(Strongly typed)의 언어이다.
             * C#은 Generic과 LINQ 등 편리한 기능을 제공한다.
             * 
             * .Net(닷넷)
             * 닷넷 프레임워크와 닷넷 코어를 합쳐서 편하게 닷넷이라고 한다.
             * 닷넷은 소프트웨어 프레임워크로, 응용 프로그램의 개발 속도를 높이는 데 도움이 되는
             * API(Application Programming Interface) 및 서비스 모음이다.
             * 
             * 함수, 라이브러리, API
             * 함수: 프로그램에서 사용하기 위한 기능의 단위를 의미한다. 보통 하나의 함수는 하나의 기능을 한다.
             * 라이브러리: 어떠한 기능을 구현할 때 도움이 되는 기능, 함수의 모음이다.
             * API: 어떠한 기능을 구현할 때 도움이 되도록 문서와 함께 제공되는 라이브러리, 함수의 모음이다.
             * 
             * 플랫폼
             * 프로그램을 실행하기 위한 배경 환경 또는 운영체제를 의미한다.
             * */
        }

        //! 첫 C# 프로그램을 작성하고 문법을 설명한다.
        public static void FirstProgram()
        {
            Console.WriteLine("Hello, World!");

            /**
             * C#의 기본 코드 구조
             * C# 프로그램은 class와 Main() 메서드가 반드시 있어야 하고, 하나 이상의 문(Statement)이 있어야 한다.
             * C#의 기본 코드는 위쪽에 네임스페이스 선언부와 Main() 메서드가 오고, 중괄호 시작과 끝을 사용하여 
             * 프로그램 범위를 구분한다.
             * 
             * 네임스페이스: 자주 사용하는 네임스페이스를 위쪽에 미리 선언해 둘 수 있다.
             * Main() 메서드: 프로그램의 시작 지점이며, 반드시 있어야 한다.
             * 중괄호({}): 프로그램 범위(Scope)를 구분 짓는다.
             * 세미콜론(;): 명령어(문, 문장)의 끝을 나타낸다.
             * 
             * Main() 메서드
             * 메서드(Method): 클래스에서 제공하는 멤버 함수를 의미한다.
             * Main() 앞에 static 키워드가 있어 개체를 생성하지 않고 바로 실행할 수 있다.
             * Main() 메서드가 2개이면 "프로그램 진입점이 2개 이상 정의되어 있습니다."라는 
             * 에러 메시지가 출력되어 프로그램이 컴파일되지 않는다.
             * 
             * 대 • 소문자 구분하기
             * C#은 대 • 소문자를 구분한다. 정확히 입력하지 않으면 에러가 발생한다.
             * 
             * 문법, 스타일, 패턴
             * 문법(Syntex): 프로그래밍을 하기 위해 반드시 지켜야 하는 규칙(Rule)이다. 언어별로 다르다.
             * 스타일(Style): 프로그래밍 가이드라인(Guideline)이다.
             * 패턴(Pattern): 자주 사용하는 규칙과 스타일 모음이다.
             * 
             * 정규화된 이름
             * 정규화된 이름(Fully qualified names)은 아래와 같이 네임스페이스 이름과 
             * 형식 이름까지 전체를 지정하는 방식이다.
             * System.Console.WriteLine()
             */

            Console.Write("Write 함수의 출력");
            Console.Write("Write 함수에 CLRF 추가 \n");
            Console.WriteLine("WriteLine 함수의 출력");

            /**
             * 이스케이프 시퀸스
             * C#은 WriteLine() 메서드에서 사용할 확장 문자를 제공하는데, 이를 
             * 이스케이프 시퀸스(Escapesequence)라고 한다. 
             * 역슬래쉬 기호와 특정 문자를 조합하면 특별한 기능을 사용 할 수 있다.
             * 어떤 이스케이프 시퀸스가 있는지 검색하면 알 수 있다.
             * 
             * 키워드로 검색하는 능력, 코드를 추론하는 능력은 아주 중요하다.
            */
        }

        #region Lab Chapter1
        public static void BuyMaxCandy()
        {
            const int CURRENT_MONEY = 1000;
            const int CANDY_PRICE = 300;
            int maxCandyCnt = CURRENT_MONEY / CANDY_PRICE;
            int exchange = CURRENT_MONEY % CANDY_PRICE;

            Console.WriteLine($"현재 가지고 있는 돈: {CURRENT_MONEY}");
            Console.WriteLine($"캔디의 가격: {CANDY_PRICE}");
            Console.WriteLine($"최대로 살 수 있는 캔디의 개수: {maxCandyCnt}");
            Console.WriteLine($"현재 가지고 있는 돈: {exchange}");
        }

        public static void Convert_FTempToCTemp()
        {
            Console.Write("화씨온도를 입력해주세요 : ");
            float fTemp = float.Parse(Console.ReadLine());
            const string desc = "화씨온도 {0}도는 섭씨온도 {1}도입니다.";
            float cTemp = (5.0f / 9.0f) * (fTemp - 32);
            Console.WriteLine(desc, fTemp, cTemp);
        }

        public static void Convert_CTempToFTemp(int cTemp)
        {
            const string desc = "섭씨온도 {0}도는 화씨온도 {1}도입니다.";
            float fTemp = (9.0f / 5.0f * cTemp) + 32;
            Console.WriteLine(desc, cTemp, fTemp);
        }

        //! 6개의 랜덤 주사위를 던져서 합을 출력한다.
        public static void Roll_RandomSixDices()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            int dice4 = random.Next(1, 7);
            int dice5 = random.Next(1, 7);
            int dice6 = random.Next(1, 7);
            int addDices = dice1 + dice2 + dice3 + dice4 + dice5 + dice6;

            Console.Write("주사위의 값 : ");
            Console.WriteLine($"{dice1}, {dice2}, {dice3}, {dice4}, {dice5}, {dice6}");
            Console.WriteLine($"모든 주사위의 합 : {addDices}");
        }
        #endregion      //  Lab Chapter1

        #region Programming Exercise Chapter1
        /** 
         * 사용자에게 주어, 동사, 목적어를 각각 물어보고 이것들을 합하여 (주어, 동사, 목적어)
         * 형태로 출력하는 프로그램
         */
        public static void MakeSentence()
        {
            string subject, verb, object_ = string.Empty;
            const string sentenceFormat = "{0} {1} a {2}";

            Console.Write("Subject : ");
            subject = Console.ReadLine();
            Console.Write("Verb : ");
            verb = Console.ReadLine();
            Console.Write("Object : ");
            object_ = Console.ReadLine();

            Console.WriteLine(sentenceFormat, subject, verb, object_);
        }

        /**
         * 사용자의 나이를 물어보고 10년 후에 몇 살이 되는지를 출력하는 프로그램
         */
        public static void AfterTenYeasLater()
        {
            int age = int.MinValue;
            Console.Write("나이 : ");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine($"10년 후에는 {age + 10}살이 됩니다.");
        }

        /**
         * 직각 삼각형의 양면 길이를 읽어서 빗변 길이를 계산하는 프로그램
         */
        public static void HypotenusRightTriangle()
        {
            double firstSide, secondSide = double.MinValue;
            Console.Write("첫 번째 변 : ");
            double.TryParse(Console.ReadLine(), out firstSide);
            Console.Write("두 번째 변 : ");
            double.TryParse(Console.ReadLine(), out secondSide);

            double sumOfPow = (firstSide * firstSide) + (secondSide * secondSide);
            double Hypotenus = Math.Sqrt(sumOfPow);
            Console.WriteLine($"빗변 길이 : {Hypotenus:F2}");
        }

        /**
         * 상자의 길이(L), 너비(W), 높이(H)를 입력하라는 메시지를 표시
         * 상자의 부피와 표면적을 계산하여 표시하는 프로그램
         * 상자의 부피   : L * W * H
         * 상자의 표면적 : 2 * ((L * W) + (L * H) + (H * W))
         */
        public static void SurfaceAndVolumOfBox()
        {
            int length, width, height = int.MinValue;
            int surface, volum = int.MinValue;

            Console.Write("길이 : ");
            int.TryParse(Console.ReadLine(), out length);
            Console.Write("너비 : ");
            int.TryParse(Console.ReadLine(), out width);
            Console.Write("높이 : ");
            int.TryParse(Console.ReadLine(), out height);

            volum = length * width * height;
            surface = 2 * ((length * width) + (length * height) + (height * width));
            Console.WriteLine($"상자의 부피 : {volum}");
            Console.WriteLine($"상자의 표면적 : {surface}");
        }

        /**
         * 우리나라에서 많이 사용되는 면적의 단위인 평을 평방미터로 환산하는 프로그램
         * 1평 = 3.3058 m^2
         * 자료형은 어떤 것을 사용하는 것이 좋은가?
         * 기호 상수를 이용하여 1평당 평방미터를 나타내시오
         */
        public static void ConvertRoomSize()
        {
            const float ONE_FLAT_OF_ROOM = 3.3058F;
            float flatOfRoom, powMeter = float.MinValue;

            Console.Write("평 : ");
            float.TryParse(Console.ReadLine(), out flatOfRoom);
            powMeter = flatOfRoom * ONE_FLAT_OF_ROOM;
            Console.WriteLine($"평방미터 : {powMeter:F3}");
        }
        #endregion      //  Programming Exercise Chapter1
    }

    //public class Program2
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Main이 2개?");
    //    }
    //}
}