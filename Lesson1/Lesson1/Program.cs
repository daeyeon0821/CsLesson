using System;
using System.Runtime.CompilerServices;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator();
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
        }       // WhatIsProgramming()

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
        }       // WhatIsCSharp()

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

            /**
             * 출력문: 명령 프롬프트에 출력하는 구문
             * 주석문: 실행에 영향을 주지 않는 코드 설명문
             */

            // 한 줄 주석문
            /* 여러 줄 주석문 */
            Console.WriteLine("출력문과 주석문 설명");
            Console.Write("Write 함수의 출력");
            Console.WriteLine("WriteLine 함수의 출력");

            /**
             * 들여쓰기: 프로그램 소스 코드의 가독성을 위해서 사용하는 일반적인 들여쓰기 규칙
             *          보통 4칸의 공백(스페이스) 또는 Tab을 사용하지만 혼용하면 안된다.
             * 공백처리: C#에서 명령어 사이, 기호와 괄호 사이의 공백, Tab, 줄 바꿈은 무시된다.
             */

            Console.WriteLine("들여쓰기와 공백처리 설명");
            Console.WriteLine(  "C# 언어의 공백처리"   );
            Console.WriteLine
            (
                "C# 언어의 공백처리"
            );

            /**
             * 이스케이프 시퀸스
             * C#은 WriteLine() 메서드에서 사용할 확장 문자를 제공하는데, 이를 
             * 이스케이프 시퀸스(Escapesequence)라고 한다. 
             * 역슬래쉬 기호와 특정 문자를 조합하면 특별한 기능을 사용 할 수 있다.
             * 어떤 이스케이프 시퀸스가 있는지 검색하면 알 수 있다.
             * 
             * 키워드로 검색하는 능력, 코드를 추론하는 능력은 아주 중요하다.
            */

            Console.Write("Write 함수의 출력");
            Console.Write("Write 함수에 New line(CLRF) 추가 \n");

            /**
             * 자리 표시자
             * C#에서 제공하는 문자열 서식(String format)에 속하는 하나의 개념이다.
             * 프로그램 실행 결과를 화면에 출력할 때 사용하는 출력문 등에서는 자리표시자 개념을 이용해서 출력 서식을
             * 지정할 수 있다. {n} 형태로 {0}, {1}, {2} 순서대로 자리를 만들고 그다음에 있는 값을 차례로 넘겨받아
             * 출력한다. 이렇게 자리 번호(인덱스)를 지정해 놓는 방법을 자리 표시자(Place holder) 또는 서식 지정자
             * (Format specifier)라고 한다.
             * 
             * 자리 표시자를 2개 만들었는데 출력할 문자열을 하나만 넘겨주면 에러가 발생한다.
             * ex) Console.WriteLine("{0}, {1}", "Hello, C#");
             */

            Console.WriteLine("{0}", "Hello, C#");          // 자리 표시자
            Console.WriteLine("{0}, {0}", "Hello, C#");     // 동일한 자리 표시자 여러 개 사용
            Console.WriteLine("{0}, {1}", "Hello", "C#");   // 자리 표시자의 인덱스 증가시켜서 사용

            /**
             * 문자열 보간법
             * 문자열 보간법(String interpolation) 또는 문자열 템플릿(String template)이라고도 한다.
             * 문자열을 묶어서 처리하기 위한 기능이다. 기존에는 String.Format() 메서드를 주로 사용했었는데,
             * C# 6.0 버전부터 $"{}" 형태로 간결하게 제공하고 있다.
             */

            const int THREE_NUMBER = 3;
            const string ODD_WORD = "홀수";
            Console.WriteLine($"{THREE_NUMBER}은(는) {ODD_WORD}입니다.");

            string stringFormat = String.Format("{0}은(는) {1}입니다.", THREE_NUMBER, ODD_WORD);
            Console.WriteLine(stringFormat);

            // 이렇게 문자열을 보간하면 특히 느리다.
            string stringPlus = THREE_NUMBER + "은(는) " + ODD_WORD + "입니다.";
            Console.WriteLine(stringPlus);
        }       // FirstProgram()

        //! 변수와 자료형에 대해 설명한다.
        public static void VariableAndDatatype()
        {
            /**
             * 변수
             * 프로그램에서 값을 다루려면 데이터를 메모리에 잠시 보관해 놓고 사용할 수 있는 임시 저장공간이 필요하다.
             * 이때 변수를 사용한다. 변수를 사용하는 순서는 선언(메모리에 공간 확보)하고 정의(대입, 할당)하여 사용하는 
             * 것이다. 변수는 데이터 형식, 변수의 이름, 대입한 값으로 이루어져 있다.
             * 변수 선언: 메모리에 데이터를 저장할 공간을 확보하는 것이다.
             * 변수 정의: 확보한 공간에 값을 저장하는 것이다.
             * 변수 초기화: 변수를 선언한 직후, 초기값으로 정의하는 것이다. 초기화는 변수의 초기값을 명확하게 정의하여
             *              원치 않는 논리적 오류를 방지하는 역할을 한다.
             *              
             * 변수의 이름을 지을 때는 다음 규칙을 지켜야 한다.
             * 변수의 첫 글자는 반드시 문자로 지정한다. 숫자는 변수의 이름의 첫글자로 사용할 수 없다.
             * 길이는 255자 이하로 하고 공백을 포함할 수 없다.
             * 영문자와 숫자, 언더스코어(_) 조합으로 사용하며, 기타 특수 기호는 사용할 수 없다.
             * C#에서 사용하는 키워드는 사용할 수 없다.
             * 변수는 대, 소문자를 구분하고, 일반적으로 소문자로 시작한다.
             * 변수는 타인이 보더라도 이해할 수 있는 이름으로 사용한다.
             */

            int number1;                // 변수 선언
            number1 = 1;                // 변수 정의
            int number2 = 2;            // 변수 선언과 초기화
            number2 = number2 + 1;      // 변수에 새로운 값을 대입

            /**
             * 데이터 형식
             * 변수에 저장할 수 있는 데이터의 종류를 자료형(Data type) 이라고 한다.
             * int, string, bool, double, object 등 C#에서 기본으로 제공하는 데이터 형식을 
             * 기본 형식(Primitive type)이라고 한다.
             */

            /**
             * 상수와 리터럴
             * 
             * 상수
             * 변수를 선언할 때 앞에 const 키워드를 붙이면 상수(Constant)가 된다. 한 번 상수로 선언된 변수는 다시
             * 값을 바꿀 수 없고, 반드시 선언과 동시에 초기화해야 한다. 이러한 const 키워드를 붙인 변수를 상수 또는
             * 지역(Local) 상수라고 한다. 상수는 주로 대문자로 표현한다.
             * 
             * 리터럴
             * 변수에 저장하기 위해 직접 대입하는 값 자체를 리터럴(Literal)이라고 한다.
             * 정수형 리터럴: 숫자 그대로 표현한다.                           ex) 1234
             * 실수형 리터럴: 대문자 F 또는 소문자 f를 접미사로 붙여 표현한다.   ex) 3.14F
             * 문자형 리터럴: 작은 따옴표로 묶어서 표현한다.                   ex) 'A'
             * 문자열 리터럴: 큰 따옴표로 묶어서 표현한다.                     ex) "Hello"
             * 
             * 숫자 구분자 사용
             * C# 7.0 버전부터는 언더스코어(_) 문자를 사용하는 숫자 구분자(Digit separator)를 제공한다.
             * 숫자 형식을 표현할 때 언더스코어 문자는 무시한다. 이를 이용하면 긴 숫자를 표시할 때 
             * 가독성을 높일 수 있다.
             */

            const float PI = 3.14F;
            int smallNumber = 1234;
            int bigNumber = 110_000;

            /**
             * null 키워드
             * C#에서 null 키워드는 '아무것도 없는 값'을 의미한다.
             * 
             * null 가능 형식(Nullable)
             * 숫자 형식의 변수를 선언할 때 int?, float? 와 같이 물음표(?) 기호를 붙이면 null 가능 형식으로 
             * 변경된다. 이러한 null 가능 형식에는 아무런 값도 없음을 의미하는 null을 대입할 수 있다.
             */

            int? nullNumber = null;

            /**
             * 자동 타입 추론(Automatic type deduction)
             * 변수에 대입하는 값의 데이터 타입이 명시적이거나 명확할 때, 데이터 타입을 명시하지 않고 생략할 수 있다. 
             * 자동 타입 추론이란 컴파일러가 대입하는 값 또는 변수의 데이터 타입으로 다른 한 쪽의 데이터 타입을 
             * 추론하는 기능을 의미한다.
             * 
             * default 값
             * C# 6.0 버전부터는 자동 타입 추론으로 기본 형식에 default 값을 대입할 수 있다.
             * 기본 형식마다 정해진 default 값이 존재한다.
             */

            var autoVariable = 10;
            int defaultNumber = default;

            /**
             * 열거형 형식
             * C#에서 열거형(Enumeration) 형식은 기억하기 어려운 상수들을 기억하기 쉬운 이름 하나로 묶어 관리하는
             * 표현 방식이다. 일반적으로 열거형으로 줄여 말한다. 열거형은 enum 키워드를 사용하고 이늄 또는 이넘으로
             * 읽는다. 열거형은 클래스 범위 내에 정의해야 하며, 메서드 범위 안에는 정의할 수 없다.
             */
        }       // VariableAndDatatype()
        enum Align { Top, Bottom, Left, Right };

        //! 문자열 입출력에 대해 설명한다.
        public static void StringInput()
        {
            /**
             * 프로그램을 실행할 때마다 서로 다른 값을 입력받으려면 콘솔에서 입력한 값을 변수에 저장할 수 있어야 한다.
             * 키보드로 입력받고 모니터로 출력하는 일반적인 내용을 표준 입출력(Standard input/output)이라고 한다.
             * 
             * System.Console.ReadLine():   콘솔에서 한 줄을 입력받는다.
             * System.Console.Read():       콘솔에서 한 문자를 정수로 입력받는다.
             * System.Console.ReadKey():    콘솔에서 다음 문자나 사용자가 누른 기능 키를 가져온다.
             */

            Console.Write("이름을 입력하시오 : ");
            string yourName = Console.ReadLine();
            Console.WriteLine("안녕하세요. {0}님.", yourName);

            /**
             * 형식 변환
             * Console.ReadLine() 메서드를 사용하여 콘솔에서 입력받은 데이터는 문자열이다. 문자열 대신 정수나 실수
             * 데이터를 입력받고 싶다면 입력된 문자열을 원하는 데이터 형식으로 변활할 수 있어야 한다.
             * 
             * 키워드: 캐스팅 연산자, 암시적(묵시적) 형변환, 명시적 형변환
             */

            Console.Write("숫자를 입력하시오 : ");
            string stringNumber = Console.ReadLine();
            int intNumber = Convert.ToInt32(stringNumber);
            Console.WriteLine("입력한 숫자 + 10은(는) {0}입니다.", intNumber + 10);

            // 2진수 처리하기
            string stringBibary = Convert.ToString(10, 2);
            int intBinary = Convert.ToInt32("0111", 2);
            Console.WriteLine("10진수 -> 2진수: {0}", stringBibary.PadLeft(8, '0'));
            Console.WriteLine("2진수 -> 10진수: {0}", intBinary);
        }       // StringInput()

        //! 연산자에 대해 설명한다.
        public static void Operator() 
        {

        }       // Operator()

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