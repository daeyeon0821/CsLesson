using Microsoft.VisualBasic.FileIO;
using System;
using System.Data.SqlTypes;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MineGame();
        }

        //! 제어문 소개
        static void ControlStatement()
        {
            /**
             * 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문), 
             * 반복 구조(반복문)가 있다.
             * 
             * 순차문
             * 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점가지 코드가 나열되면 순서대로 실행 후 
             * 종료한다.
             * 
             * 제어문
             * 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로
             * 조건문과 반복문으로 구분한다.
             * 
             * 조건문(선택문)
             * 조건의 참 또는 거짓에 따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고
             * 하기도 한다.
             * 
             * 반복문
             * 특정 명령문을 지정된 수만큼 반복해서 실행할 때나 조건식이 참일 동안 반복시킬 때 사용한다.
             */

            /**
             * if / else 문
             * 프로그램 흐름을 여러 가지 갈래로 가지치기(Branching)할 수 있는데, 이때 if 문을 사용한다.
             * if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.
             */

            // 02.3 예제 #1
            // 두개의 정수 중에서 더 큰 수를 찾는 프로그램

            int numberX, numberY;
            Console.Write("x 값을 입력하시오: ");
            int.TryParse(Console.ReadLine(), out numberX);
            Console.Write("y 값을 입력하시오: ");
            int.TryParse(Console.ReadLine(), out numberY);

            if(numberX > numberY)
            {
                Console.WriteLine("x가 y보다 큽니다.");
            }
            else
            {
                Console.WriteLine("y가 x보다 큽니다.");
            }

            /**
             * 02.4 중간점검 1
             * 컵의 사이즈를 받아서 100ml 미만은 small, 100ml 이상 200ml 미만은 medium, 200ml 이상은 
             * large라고 출력하는 if-else 문을 작성
             */

            int cupSize = 0;
            Console.Write("컵의 사이즈를 입력 : ");
            int.TryParse(Console.ReadLine(), out cupSize);

            if(cupSize < 100) { Console.WriteLine("small"); }
            else if(100 <= cupSize && cupSize < 200) { Console.WriteLine("medium"); }
            else { Console.WriteLine("large"); }
        }       // ControlStatement()

        //! switch-case 문 소개
        public static void ControlStatement2()
        {
            /**
             * 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용하다.
             * switch, case, default 키워드를 사용하여 조건을 처리한다.
             */

            Console.Write("정수 1, 2, 3 중에 하나를 입력하시오 : ");
            int switchNumber = 0;
            int.TryParse(Console.ReadLine(), out switchNumber);

            switch(switchNumber)
            {
                case 1: 
                    Console.WriteLine("1을(를) 입력했습니다."); 
                    break;
                case 2: 
                    Console.WriteLine("2을(를) 입력했습니다."); 
                    break;
                case 3: 
                    Console.WriteLine("3을(를) 입력했습니다."); 
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다.");
                    break;
            }       // switch(switchNumber)

            /**
             * 02.5 중간점검
             * 1. case 절에서 break 문을 생략하면 어떻게 되는가?
             * 2. 변수 fruit의 값이 각각 1, 2, 5일 때, 다음 코드의 출력?
             */

            int fruit = 2;
            switch(fruit)
            {
                case 1: Console.Write("사과"); break;
                case 2: Console.Write("배"); goto case 3;
                case 3: Console.Write("바나나"); break;
                default: Console.Write("과일"); break;
            }
        }       // ControlStatement2()

        //! 반복문 소개하기 - while
        public static void WhileLoop()
        {
            /**
             * while 문은 조건식이 참일 동안 문장을 반복 실행한다.
             */

            // 10 ~ 1 카운트 후 발사 출력하는 프로그램
            int whileCnt = 10;
            while(whileCnt > 0 ) 
            {
                Console.Write("{0} ", whileCnt);
                whileCnt--;
            }
            Console.WriteLine(" 발사!");

            // 예제 #1 - 구구단 출력하는 프로그램. User input을 받아서 해당 단을 출력
            int userGugudan = 0;
            Console.Write("구구단 중에서 출력하고 싶은 단 입력: ");
            int.TryParse(Console.ReadLine(), out userGugudan);

            const int GUGU_LOOP_CNT = 9;
            int guguLoopIdx = 1;
            while(guguLoopIdx <= GUGU_LOOP_CNT) 
            {
                Console.WriteLine("{0}*{1}={2}", userGugudan, guguLoopIdx, userGugudan * guguLoopIdx);
                guguLoopIdx++;
            }
        }       // WhileLoop()

        //! 반복문 소개하기 - for
        public static void ForLoop()
        {
            /**
             * for 문은 일정한 횟수만큼 반복할 때 유용하다.
             * 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날 때마다 증감식이
             * 실행된다.
             */

            // 1부터 10까지 정수의 합
            int sumNumber = 0;
            for(int index = 1; index <= 10; index++)
            {
                sumNumber += index;
            }
            Console.WriteLine("1부터 10까지의 정수의 합 = {0}", sumNumber);

            /**
             * break 문
             * break 문은 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고
             * 반복 루프 다음에 있는 문장이 실행된다.
             * 
             * continue 문
             * continue 문은 현재 수행하고 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로
             * 시작하게 만든다. 반복 루프에서 continue 문을 만나게 되면 continue 문 다음에 있는 후속 코드들은
             * 실행되지 않고 건너뛰게 된다.
             */

            // 1~100 중 3의 배수를 제외한 수의 합 구하기
            int sumWithout3Multiple = 0;
            for(int index = 1; index <= 100; index++)
            {
                if(index % 3 == 0) { continue; }
                sumWithout3Multiple += index;
            }
            Console.WriteLine("3의 배수를 제외한 정수의 합 (1~100): {0}", sumWithout3Multiple);
        }       // ForLoop()

        //! foreach 소개하기
        public static void ForeachLoop()
        {
            /**
             * foreach 문은 배열(Array)이나 컬렉션(Collection) 같은 값을 여러 개 담고 있는 데이터 구조에서
             * 각각의 데이터가 들어 있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 처리할 필요가 없다.
             */

            // string 에서 글자를 하나씩 출력
            string stringText = "Hello World!";

            foreach(char oneCharactor in stringText)
            {
                Console.Write("{0} ", oneCharactor);
            }
        }       // ForeachLoop()

        //! 배열 소개하기
        public static void ArrayType()
        {
            /**
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Collection) 또는 컨테이너(Container)
             * 라고 한다. C#에서 다루는 컬렉션은 배열(Array), 리스트(List), 사전(Dictinary) 등이 있다.
             * 
             * 배열
             * 배열(Array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다. 각각의 데이터들은 
             * 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작하는 정수형 인덱스를 사용하여
             * 접근할 수 있다.
             * 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
             * 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
             * 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상된다.
             * 
             * 배열에는 세 가지 종류가 있다.
             * 1차원 배열: 배열의 첨자를 하나만 사용하는 배열
             * 다차원 배열: 첨자 2개 이상을 사용하는 배열 (2차원, 3차원 ...)
             * 가변(Jagged) 배열: '배열의 배열'이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현
             */

            // 배열 선언과 초기화
            int[] sales = new int[5] { 100, 200, 300, 400, 500 };

            // 배열의 Length 필드
            for(int index = 0; index < sales.Length; index++)
            {
                Console.Write("{0} ", sales[index]);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            /**
             * 다차원 배열
             * 2차원 배열, 3차원 배열처럼 차원이 2 이상인 배열을 다차원 배열이라고 한다.
             * C#에서 배열을 선언할 때는 콤마를 기준으로 차원을 구분한다.
             */

            int[] oneArray = new int[2] { 1, 2 };
            int[,] twoArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,,] threeArray = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            // 3행 3열짜리 배열에서 행과 열이 같으면 1, 다르면 0을 출력
            twoArray = new int[3, 3];

            for (int y = 0; y <= twoArray.GetUpperBound(0); y++)
            {
                for (int x = 0; x <= twoArray.GetUpperBound(1); x++)
                {
                    if(x == y) { twoArray[y, x] = 1; }
                    else { twoArray[y, x] = 0; }

                    Console.Write("{0} ", twoArray[y, x]);
                }
                Console.WriteLine("");
            }       // loop
            Console.WriteLine();

            /**
             * 가변 배열
             * 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
             */

            int[][] zagArray = new int[2][];
            zagArray[0] = new int[] { 1, 2 };
            zagArray[1] = new int[] { 3, 4, 5 };
            for(int y = 0; y <= zagArray.GetUpperBound(0); y++)
            {
                for(int x = 0; x < zagArray[y].Length; x++)
                {
                    Console.Write("{0} ", zagArray[y][x]);
                }
                Console.WriteLine();
            }       // loop
        }       // ArrayType()

        #region Chapter 02 Lab
        /**
         * 비밀 코드 맞추기
         * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 프로그램
         * 비밀 코드는 a ~ z 사이의 문자
         * 컴퓨터는 사용자의 추측을 읽고 자신의 비밀 코드와 비교 후 힌트를 준다
         * 힌트는 입력한 코드가 비밀 코드보다 앞에 있는지 뒤에 있는지
         */
        public static void SecretCode()
        {
            char secretCode = 'h';
            char userCode = default;

            Console.Write("비밀 코드를 맞춰보세요: ");
            char.TryParse(Console.ReadLine(), out userCode);

            if (secretCode.Equals(userCode)) { Console.WriteLine("정답!"); }
            else if(secretCode < userCode) { Console.WriteLine("{0}앞에 있음", userCode); }
            else { Console.WriteLine("{0}뒤에 있음", userCode); }
        }       // SecretCode()

        /**
         * 세 개의 정수 중에서 큰 수 찾기
         * 사용자로부터 받은 3개의 정수 중에서 가장 큰 수를 찾는 프로그램
         */
        public static void MaxNumberAtThree()
        {
            int number1, number2, number3 = 0;
            int maxNumber = int.MinValue;

            Console.WriteLine("3개의 정수를 입력하시오");
            Console.Write("1번 정수: ");
            int.TryParse(Console.ReadLine(), out number1);
            Console.Write("2번 정수: ");
            int.TryParse(Console.ReadLine(), out number2);
            Console.Write("3번 정수: ");
            int.TryParse(Console.ReadLine(), out number3);

            if(number2 <= number1) { maxNumber = number1; }
            else { maxNumber = number2; }
            if (maxNumber <= number3) { maxNumber = number3; }
            else { /* Do nothing */ }
            Console.WriteLine("가장 큰 정수는 {0}", maxNumber);
        }       // MaxNumberAtThree()

        /**
         * 자음과 모음 개수 세기
         * 사용자로부터 영문자를 받아서 자음과 모음의 개수를 세는 프로그램
         */
        public static void ConsonantVowelCounter()
        {
            Console.WriteLine("영문자를 입력하고 마지막에 컨트롤-Z를 입력하세요.");
            char userCharactor = '0';
            int consonantCnt = 0;
            int vowelCnt = 0;

            while (true)
            {
                char.TryParse(Console.ReadLine(), out userCharactor);
                if(userCharactor.Equals(default)) { break; }

                switch (userCharactor)
                {
                    case 'u':
                    case 'o': 
                    case 'i': 
                    case 'e': 
                    case 'a': vowelCnt++; break;
                    default: consonantCnt++; break;
                }       // switch (userCharactor)
            }       // while (true)
            Console.WriteLine("모음: {0, 4}", vowelCnt);
            Console.WriteLine("자음: {0, 4}", consonantCnt);
        }       // ConsonentVowelCounter()

        /**
         * 숫자 맞추기 게임
         * 1~100 사이의 정수 미리 셋업
         * user input -> 점수가 높은지, 낮은지 힌트
         * 맞출 경우 시도 횟수와 함께 엔딩
         */
        public static void GuessNumberGame()
        {
            Random randomNumber = new Random();
            int numberAnswer = randomNumber.Next(1, 100 + 1);
            int userNumber = 0;
            int tryCount = 0;

            while (true)
            {
                Console.Write("정답을 추측하여 보시오: ");
                int.TryParse(Console.ReadLine(), out userNumber);
                tryCount++;
                if (userNumber.Equals(numberAnswer)) { break; }

                if(userNumber < numberAnswer) { Console.WriteLine("제시한 점수가 낮습니다."); }
                else { Console.WriteLine("제시한 점수가 높습니다."); }
            }       // while
            Console.WriteLine("축하합니다. 시도 횟수={0}", tryCount);
        }       // GuessNumberGame()

        /**
         * 숫자 맞추기 게임 (도전문제 1~2)
         * 유저가 아닌 컴퓨터가 맞추도록 수정
         * 7번 이하의 추측으로
         */
        public static void GuessNumberGame2()
        {
            int userNumber = 0;
            int tryCount = 0;
            int computerGuess_fore = 0;
            int computerGuess_last = 100 + 1;
            int computerGuess_average = 0;
            Task loopTask = null;

            Console.Write("정답을 제시하여 보시오: ");
            int.TryParse(Console.ReadLine(), out userNumber);

            while (true)
            {
                tryCount++;
                computerGuess_average = (int)((computerGuess_fore + computerGuess_last) * 0.5f);
                if(userNumber.Equals(computerGuess_average)) { break; }

                if (userNumber < computerGuess_average)
                {
                    Console.WriteLine("{0} -> 제시한 점수가 높습니다.", computerGuess_average);
                    computerGuess_last = computerGuess_average;
                }
                else
                {
                    Console.WriteLine("{0} -> 제시한 점수가 낮습니다.", computerGuess_average);
                    computerGuess_fore = computerGuess_average;
                }

                loopTask = Task.Run(async () =>
                {
                    await Task.Delay(300);
                });
                loopTask.Wait();
            }       // while()
            Console.WriteLine("정답은 {0}입니다. 시도 횟수: {1}", computerGuess_average, tryCount);
        }       // GuessNumberGame2()

        /**
         * 도형의 면적 계산하기
         * 사용자가 도형을 선택. 1, 2, 3 은 사각형, 원, 삼각형
         * 사각형은 가로, 세로
         * 원은 반지름
         * 삼각형은 밑변과 높이 입력 받는다
         */
        public static void AreaOfFigures()
        {
            int figureType = 0;
            Console.Write("도형을 선택하시오. (1. 사각형, 2. 원, 3. 삼각형): ");
            int.TryParse(Console.ReadLine(), out figureType);

            int userInput1, userInput2 = 0;
            switch (figureType)
            {
                case 1:
                    Console.Write("가로: ");
                    int.TryParse(Console.ReadLine(), out userInput1);
                    Console.Write("세로: ");
                    int.TryParse(Console.ReadLine(), out userInput2);
                    Console.WriteLine("면적: {0}", userInput1 * userInput2);
                    break;
                case 2:
                    Console.Write("반지름: ");
                    int.TryParse(Console.ReadLine(), out userInput1);
                    Console.WriteLine("면적: {0}", MathF.PI * (userInput1 * userInput1));
                    break;
                case 3:
                    Console.Write("밑변: ");
                    int.TryParse(Console.ReadLine(), out userInput1);
                    Console.Write("높이: ");
                    int.TryParse(Console.ReadLine(), out userInput2);
                    Console.WriteLine("면적: {0}", userInput1 * userInput2 * 0.5f);
                    break;
                default:
                    Console.WriteLine("처리하지 않은 예외 입력입니다.");
                    break;
            }       // switch (figureType)
        }       // AreaOfFigures()

        /**
         * 산수 문제 자동 출제
         * 덧셈, 뺄셈, 곱셈, 나눗셈 문제를 자동 생성. 타겟은 0~99 사이의 난수
         * 답을 맞추면 종료
         */
        public static void RandomArithmeticQuiz()
        {
            Random randomNumber = new Random();
            int sourTarget = randomNumber.Next(0, 99 + 1);
            int destTarget = randomNumber.Next(1, 99 + 1);
            int arithmeticType = randomNumber.Next(1, 4 + 1);

            string arithmeticSign = string.Empty;
            string quizAnswer = string.Empty;

            switch(arithmeticType)
            {
                case 1: 
                    quizAnswer = Convert.ToString( sourTarget + destTarget);
                    arithmeticSign = "+";
                    break;
                case 2:
                    quizAnswer = Convert.ToString(sourTarget - destTarget);
                    arithmeticSign = "-";
                    break;
                case 3:
                    quizAnswer = Convert.ToString(sourTarget * destTarget);
                    arithmeticSign= "*";
                    break;
                case 4:
                    quizAnswer = Convert.ToString(MathF.Round(
                        (float)sourTarget / (float)destTarget, 2)
                        );
                    arithmeticSign = "/";
                    break;
            }       // switch

            string userAnswer = string.Empty;
            while (true)
            {
                Console.Write($"{sourTarget} {arithmeticSign} {destTarget} = ");
                userAnswer = Console.ReadLine();
                if (userAnswer.Equals(quizAnswer)) { break; }

                Console.WriteLine("틀렸습니다.");
            }       // while
            Console.WriteLine("맞았습니다.");
        }       // RandomArithmeticQuiz()

        /**
         * 배열에서 최대값 찾기
         * 크기가 100인 배열을 1~100 사이의 난수로 채움
         * 그 중 최대값을 찾아서 출력
         */
        public static void FindMaxValueAtArray()
        {
            Random randomNumber = new Random();
            const int ARRAY_SIZE = 100;
            int[] numberArray = new int[ARRAY_SIZE];

            int loopIndex = 0;
            for(loopIndex = 0; loopIndex < numberArray.Length; loopIndex++)
            {
                numberArray[loopIndex] = randomNumber.Next(1, ARRAY_SIZE + 1);
            }

            int maxNumber = 0;
            int maxLocation = 0;
            loopIndex = 0;
            foreach(int number in numberArray)
            {
                loopIndex++;
                if(maxNumber <= number) 
                {
                    maxNumber = number;
                    maxLocation = loopIndex;
                }
                Console.Write("{0}".PadRight(4, ' '), number);

                if(loopIndex % 10 == 0) { Console.WriteLine(); }
            }       // loop
            Console.WriteLine();
            Console.WriteLine("최대값: {0}, 최대값 위치: {1} 번째 숫자", maxNumber, maxLocation);
        }       // FindMaxValueAtArray()

        /**
         * 사과를 제일 좋아하는 사람 찾기
         * 10 명의 사람에게 아침에 먹는 사과의 수를 입력 받음.
         * 누가 가장 사과를 적게 먹는지, 많이 먹는지 출력.
         * 정렬해서 출력
         */
        public static void FindMostLikeApple()
        {
            const int INPUT_COUNT = 5;
            int loopIndex = 0;
            int[] appleArray = new int[INPUT_COUNT];

            int maxApple = int.MinValue;
            int maxLocation = 0;
            int minApple = int.MaxValue;
            int minLocation = 0;
            // 사과의 수를 입력받음
            for(loopIndex = 0; loopIndex < appleArray.Length; loopIndex++)
            {
                Console.Write("아침에 먹는 사과의 개수: ");
                int.TryParse(Console.ReadLine(), out appleArray[loopIndex]);

                if (appleArray[loopIndex] <= minApple) 
                { 
                    minApple = appleArray[loopIndex];
                    minLocation = loopIndex + 1;
                }
                if (maxApple <= appleArray[loopIndex]) 
                { 
                    maxApple = appleArray[loopIndex]; 
                    maxLocation = loopIndex + 1;
                }
            }       // loop

            Console.WriteLine("가장 적은 사과를 먹은 사람은 {0} 번째", minLocation);
            Console.WriteLine("가장 많은 사과를 먹은 사람은 {0} 번째", maxLocation);

            // 여기서 정렬
            int tempValue = 0;
            for(loopIndex = 0; loopIndex < appleArray.Length; loopIndex++)
            {
                for(int elementIdx = 0; elementIdx < (appleArray.Length - loopIndex); elementIdx++)
                {
                    if(elementIdx.Equals(appleArray.Length - 1)) { break; }
                    if (appleArray[elementIdx+1] <= appleArray[elementIdx])
                    {
                        tempValue = appleArray[elementIdx];
                        appleArray[elementIdx] = appleArray[elementIdx+1];
                        appleArray[elementIdx+1] = tempValue;
                    }       // if: 현재 인덱스가 다음 인덱스의 값보다 큰 경우 스왑
                }       // loop: 루프가 돌 때마다 서치 범위를 전체 배열의 길이에서 한 칸씩 줄임
            }       // loop

            // 여기서 정렬한 배열 출력
            Console.WriteLine();
            Console.WriteLine("사과의 갯수 정렬");
            foreach (int element in appleArray)
            {
                Console.Write("{0}".PadRight(4, ' '), element);
            }       // loop
            Console.WriteLine();
        }       // FindMostLikeApple()

        /**
         * Tic-Tac-Toe 게임
         * 컴퓨터와 사람이 번갈아 가면서 o, x 를 둔다.
         * 보드 크기는 3 x 3
         * 컴퓨터의 룰은 간단하게
         * 1. 중앙이 비었으면 중앙 선점
         * 2. 이후에 빈자리 적당히 찾아서 둔다
         */
        enum TicTacToePlayerType
        {
            NONE = 0, PLAYER, COMPUTER
        }
        public static void TicTacToeGame()
        {
            int[,] gameBoard = new int[3, 3];
            int playerX, playerY = 0;
            bool isValidLocation = false;
            bool isPlayerTurn = false;
            bool isGameOver = false;

            string playerIcon = string.Empty;
            string playerType = string.Empty;

            while (isGameOver == false)
            {
                // 플레이어 턴 진행
                isPlayerTurn = true;
                playerType = "[플레이어]";
                // { 플레이어에게서 좌표를 입력 받는다
                playerX = 0;
                playerY = 0;
                isValidLocation = false;
                while (true)
                {
                    if (isValidLocation == true) { break; }

                    // 플레이어 턴 / 좌표 입력 받음
                    Console.Write("[플레이어] (x) 좌표: ");
                    int.TryParse(Console.ReadLine(), out playerX);
                    Console.Write("[플레이어] (y) 좌표: ");
                    int.TryParse(Console.ReadLine(), out playerY);

                    if (gameBoard[playerY, playerX].Equals((int)TicTacToePlayerType.NONE))
                    {
                        gameBoard[playerY, playerX] = (int)(TicTacToePlayerType.PLAYER);
                        isValidLocation = true;
                    }       // if: 보드가 빈 곳인 경우
                    else
                    {
                        Console.WriteLine("[System] 해당 좌표는 비어있지 않습니다. / 다른 좌표를 입력하세요");
                        isValidLocation = false;
                    }       // else: 보드가 빈 곳이 아닌 경우
                }       // loop: 플레이어의 좌표 입력을 받는 루프
                // } 플레이어에게서 좌표를 입력 받는다

                // { 플레이어의 턴 진행을 보드에 출력한다
                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    Console.WriteLine("---|---|---");
                    for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;
                        }       // switch
                        Console.Write(" {0} ", playerIcon);

                        // Print Separator
                        if (x == gameBoard.GetUpperBound(1)) { /* Do nothing */ }
                        else { Console.Write("|"); }
                    }       // loop: 한 줄에서 출력할 내용을 연산한다
                    Console.WriteLine();
                }       // loop
                Console.WriteLine("---|---|---");
                // } 플레이어의 턴 진행을 보드에 출력한다

                // { 게임이 끝났는지 보드 검사
                Console.WriteLine();
                isGameOver = false;
                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    if (gameBoard[y, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[y, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[y, 2].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameOver = true;
                    }
                    else { continue; }
                }       // loop: 가로 방향으로 검사

                for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                {
                    if (gameBoard[0, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[1, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[2, x].Equals((int)TicTacToePlayerType.PLAYER))
                    {
                        isGameOver = true;
                    }
                    else { continue; }
                }       // loop: 세로 방향으로 검사

                // 대각선 방향으로 검사
                if (gameBoard[0, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[2, 2].Equals((int)TicTacToePlayerType.PLAYER))
                {
                    isGameOver = true;
                }
                if (gameBoard[0, 2].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[2, 0].Equals((int)TicTacToePlayerType.PLAYER))
                {
                    isGameOver = true;
                }
                // } 게임이 끝났는지 보드 검사

                if (isGameOver) { break; }

                // 게임이 끝나지 않은 경우 턴을 교체한다
                isPlayerTurn = false;
                playerType = "[컴퓨터]";
                bool isComputerDoing = false;

                Console.WriteLine("{0}의 턴", playerType);
                // 컴퓨터는 간단한 룰
                // { 1. 중앙이 비어 있으면 선점
                if (isComputerDoing == false)
                {
                    if (gameBoard[1, 1].Equals((int)TicTacToePlayerType.NONE))
                    {
                        gameBoard[1, 1] = (int)TicTacToePlayerType.COMPUTER;
                        isComputerDoing = true;
                    }       // if: 중앙이 비어 있는 경우
                    else { /* Do nothing */ }
                }       // if: 컴퓨터가 아직 아무것도 하지 않은 경우
                else { /* Do nothing */ }
                // } 1. 중앙이 비어 있으면 선점

                // { 2. 적당히 빈 자리 찾아서 착수
                if (isComputerDoing == false)
                {
                    for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                    {
                        for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                        {
                            if (isComputerDoing == false &&
                                gameBoard[y, x].Equals((int)TicTacToePlayerType.NONE))
                            {
                                gameBoard[y, x] = (int)TicTacToePlayerType.COMPUTER;
                                isComputerDoing = true;
                                break;
                            }       // if: 서치한 자리가 비어있는 경우
                            else { continue; }
                        }       // loop: Search horizontal
                    }       // loop: Search vertical
                }       // if: 컴퓨터가 아직 아무것도 하지 않은 경우
                else { /* Do nothing */ }
                // } 2. 적당히 빈 자리 찾아서 착수

                // { 컴퓨터의 턴 진행을 보드에 출력한다
                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    Console.WriteLine("---|---|---");
                    for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                    {
                        switch (gameBoard[y, x])
                        {
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;
                        }       // switch
                        Console.Write(" {0} ", playerIcon);

                        // Print Separator
                        if (x == gameBoard.GetUpperBound(1)) { /* Do nothing */ }
                        else { Console.Write("|"); }
                    }       // loop: 한 줄에서 출력할 내용을 연산한다
                    Console.WriteLine();
                }       // loop
                Console.WriteLine("---|---|---");
                // } 컴퓨터의 턴 진행을 보드에 출력한다

                // { 게임이 끝났는지 보드 검사
                Console.WriteLine();
                isGameOver = false;
                for (int y = 0; y <= gameBoard.GetUpperBound(0); y++)
                {
                    if (gameBoard[y, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[y, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[y, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameOver = true;
                    }
                    else { continue; }
                }       // loop: 가로 방향으로 검사

                for (int x = 0; x <= gameBoard.GetUpperBound(1); x++)
                {
                    if (gameBoard[0, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[1, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[2, x].Equals((int)TicTacToePlayerType.COMPUTER))
                    {
                        isGameOver = true;
                    }
                    else { continue; }
                }       // loop: 세로 방향으로 검사

                // 대각선 방향으로 검사
                if (gameBoard[0, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[2, 2].Equals((int)TicTacToePlayerType.COMPUTER))
                {
                    isGameOver = true;
                }
                if (gameBoard[0, 2].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[2, 0].Equals((int)TicTacToePlayerType.COMPUTER))
                {
                    isGameOver = true;
                }
                // } 게임이 끝났는지 보드 검사
            }       // loop: 틱택토 게임 루프

            // 누가 이겼는지 출력
            Console.WriteLine("{0}의 승리!", playerType);
        }       // TicTacToeGame()

        /**
         * 지뢰 찾기
         * 10 x 10 보드에 지뢰를 숨김 (n% 확률로 지뢰 매설)
         * debug mode 에서 지뢰가 아닌 곳은 .(닷), 지뢰인 곳은 #(샵)으로 표현
         * play mode 에서 확인 되지 않은 곳은 전부 □(스퀘어) 로 표현
         * 첫 턴에 지뢰를 밟으면 해당 칸에 지뢰를 지워 줌
         */
        public static void MineGame()
        {
            Random randomMine = new Random();
            const int MINE_PERCENTAGE = 30;
            const int BOARD_SIZE_X = 5;
            const int BOARD_SIZE_Y = 5;

            bool isDebugMode = true;
            bool isGameOver = false;
            bool isPlayerWin = false;
            int playerTurnCnt = 0;

            // 10 x 10 보드에 지뢰 초기화한다
            /*
             * gameBoard 상태
             *  지뢰: MINE_PERCENTAGE 미만의 값
             * 빈 칸: MINE_PERCENTAGE 이상의 값
             * 
             * playBoard 상태
             * -2: 지뢰 있음
             * -1: 초기값
             *  n: 주변 9타일 이내에 지뢰 수 (0일 경우 ■ 표기, 양수일 경우 정수 표기)
             *  
             * mineCntBoard 상태
             * -1: 지뢰 있음
             *  n: 주변 9타일 이내에 지뢰 수
             */
            int[,] gameBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] playBoard = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            int[,] mineCntMap = new int[BOARD_SIZE_Y, BOARD_SIZE_X];
            for(int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for(int x = 0; x < BOARD_SIZE_X; x++)
                {
                    gameBoard[y, x] = randomMine.Next(1, 100 + 1);
                    playBoard[y, x] = -1;

                    if (gameBoard[y, x] < MINE_PERCENTAGE)
                    {
                        mineCntMap[y, x] = -1;
                        //playBoard[y, x] = -2;
                    }       // if: 지뢰가 셋업된 경우
                    else
                    {
                        mineCntMap[y, x] = 0;
                        //playBoard[y, x] = -1;
                    }       // else: 지뢰가 없는 경우
                }
            }       // loop: 지뢰를 초기화

            // 게임 시작
            while (isGameOver == false)
            {
                // { 현재 보드의 상태를 플레이 시점으로 보여준다
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        switch (playBoard[y, x])
                        {
                            case -2:
                                Console.Write("X".PadRight(3, ' '));
                                break;
                            case -1:
                                Console.Write("□".PadRight(2, ' '));
                                break;
                            case 0:
                                Console.Write("■".PadRight(2, ' '));
                                break;
                            default:
                                Console.Write("{0}".PadRight(5, ' '), playBoard[y, x]);
                                break;
                        }       // switch
                    }       // loop
                    Console.WriteLine();
                }       // loop: 현재 보드의 상태를 출력
                Console.WriteLine();
                // } 현재 보드의 상태를 플레이 시점으로 보여준다

                int playerX = 0;
                int playerY = 0;
                bool isLocationValid = false;
                // { 플레이어 좌표 입력
                while (isLocationValid == false)
                {
                    Console.Write("[플레이어] x 좌표 입력: ");
                    int.TryParse(Console.ReadLine(), out playerX);
                    Console.Write("[플레이어] y 좌표 입력: ");
                    int.TryParse(Console.ReadLine(), out playerY);

                    // 플레이어가 입력한 좌표의 유효성을 검사한다
                    isLocationValid =
                        (0 <= playerX && playerX < BOARD_SIZE_X) &&
                        (0 <= playerY && playerY < BOARD_SIZE_Y);
                    if (isLocationValid == false)
                    {
                        Console.WriteLine("{0} {1}", "[System] 해당 좌표는 유효하지 않습니다.",
                            "다른 좌표를 입력하세요 \n");
                        continue;
                    }       // if: 좌표를 잘못 입력한 경우

                    // 플레이 보드에서 선택 가능한지 검사한다
                    isLocationValid = isLocationValid && playBoard[playerY, playerX].Equals(-1);
                    if (isLocationValid == false)
                    {
                        Console.WriteLine("{0} {1}", "[System] 해당 좌표는 이미 오픈되었습니다.",
                            "다른 좌표를 입력하세요. \n");
                        continue;
                    }       // if: 오픈된 좌표를 선택한 경우
                }       // loop
                playerTurnCnt++;
                // } 플레이어 좌표 입력

                // 현재 첫 턴이라면 해당 좌표에 지뢰가 있어도 지워준다
                if (playerTurnCnt.Equals(1))
                {
                    gameBoard[playerY, playerX] = MINE_PERCENTAGE + 1;
                    mineCntMap[playerY, playerX] = 0;
                    playBoard[playerY, playerX] = -1;

                    // { 지뢰의 수를 세어서 지도를 생성한다
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            // 지뢰가 없는 곳은 넘어간다
                            if (mineCntMap[y, x].Equals(-1) == false) { continue; }

                            // 지뢰 주변 9타일에 수를 1씩 추가한다
                            bool isSearchTileValid = false;
                            for (int searchY = y - 1; searchY <= y + 1; searchY++)
                            {
                                for (int searchX = x - 1; searchX <= x + 1; searchX++)
                                {
                                    // 유효하지 않은 좌표는 패스한다
                                    isSearchTileValid =
                                        (0 <= searchX && searchX < BOARD_SIZE_X) &&
                                        (0 <= searchY && searchY < BOARD_SIZE_Y);
                                    if (isSearchTileValid == false) { continue; }
                                    // 9타일 서치 중에 지뢰가 있다면 패스한다
                                    if (mineCntMap[searchY, searchX].Equals(-1)) { continue; }

                                    mineCntMap[searchY, searchX]++;
                                }
                            }       // loop: 지뢰 주변 9타일을 찾는 루프
                        }
                    }       // loop: 게임 보드를 순회하는 루프
                            // } 지뢰의 수를 세어서 지도를 생성한다
                }       // if: 첫 턴인 경우

                // { 선택한 좌표에서 지뢰를 검사한다
                if (gameBoard[playerY, playerX] < MINE_PERCENTAGE)
                {
                    isGameOver = true;
                    isPlayerWin = false;
                    playBoard[playerY, playerX] = -2;
                }       // if: 지뢰를 선택한 경우
                else
                {
                    // { 선택한 타일 인근 9칸의 숫자를 오픈한다
                    bool isSearchTileValid = false;
                    for (int searchY = playerY - 1; searchY <= playerY + 1; searchY++)
                    {
                        for (int searchX = playerX - 1; searchX <= playerX + 1; searchX++)
                        {
                            // 유효하지 않은 좌표는 패스한다
                            isSearchTileValid =
                                (0 <= searchX && searchX < BOARD_SIZE_X) &&
                                (0 <= searchY && searchY < BOARD_SIZE_Y);
                            if (isSearchTileValid == false) { continue; }

                            if (mineCntMap[searchY, searchX].Equals(-1))
                            {
                                playBoard[searchY, searchX] = -2;
                            }       // if: 지뢰인 경우
                            else
                            {
                                playBoard[searchY, searchX] = mineCntMap[searchY, searchX];
                            }       // else: 지뢰 아닌 경우
                        }
                    }       // loop: 선택한 타일 인근 9칸을 순회하는 루프
                            // } 선택한 타일 인근 9칸의 숫자를 오픈한다
                }       // else: 빈 땅을 선택한 경우
                        // } 선택한 좌표에서 지뢰를 검사한다

                // { 게임 승리 조건을 검사한다
                int unknownTileCnt = 0;
                for (int y = 0; y < BOARD_SIZE_Y; y++)
                {
                    // 오픈되지 않은 타일이 있는 경우 게임을 이어서 진행한다
                    if (0 < unknownTileCnt) { break; }

                    for (int x = 0; x < BOARD_SIZE_X; x++)
                    {
                        // 오픈되지 않은 타일이 있는 경우 게임을 이어서 진행한다
                        if (0 < unknownTileCnt) { break; }

                        if (playBoard[y, x].Equals(-1) &&
                            mineCntMap[y, x].Equals(-1) == false)
                        {
                            unknownTileCnt++;
                        }       // if: 아직 오픈할 타일이 존재하고, 해당 타일이 지뢰가 아닌 경우
                    }
                }       // loop: 플레이 보드를 순회하는 루프
                if (unknownTileCnt.Equals(0))
                {
                    isGameOver = true;
                    isPlayerWin = true;
                }
                // } 게임 승리 조건을 검사한다

                // { 게임 종료 조건을 검사한다
                if (isGameOver) { break; }
                // } 게임 종료 조건을 검사한다

                if (isDebugMode)
                {
                    // { 현재 보드의 상태를 숫자 지도로 보여준다
                    Console.WriteLine();
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            Console.Write("{0} ", mineCntMap[y, x]);
                        }
                        Console.WriteLine();
                    }       // loop: 현재 보드의 상태를 출력
                            // } 현재 보드의 상태를 숫자 지도로 보여준다

                    // { 현재 보드의 상태를 보여준다
                    Console.WriteLine();
                    for (int y = 0; y < BOARD_SIZE_Y; y++)
                    {
                        for (int x = 0; x < BOARD_SIZE_X; x++)
                        {
                            if (gameBoard[y, x] < MINE_PERCENTAGE)
                            {
                                Console.Write("# ");
                            }
                            else
                            {
                                Console.Write(". ");
                            }
                        }
                        Console.WriteLine();
                    }       // loop: 현재 보드의 상태를 출력
                    Console.WriteLine();
                    // } 현재 보드의 상태를 보여준다
                }       // if: 디버그 모드
            }       // loop: 게임 루프

            // { 현재 보드의 상태를 플레이 시점으로 보여준다
            Console.WriteLine();
            for (int y = 0; y < BOARD_SIZE_Y; y++)
            {
                for (int x = 0; x < BOARD_SIZE_X; x++)
                {
                    switch (playBoard[y, x])
                    {
                        case -2:
                            Console.Write("X".PadRight(3, ' '));
                            break;
                        case -1:
                            Console.Write("□".PadRight(2, ' '));
                            break;
                        case 0:
                            Console.Write("■".PadRight(2, ' '));
                            break;
                        default:
                            Console.Write("{0}".PadRight(5, ' '), playBoard[y, x]);
                            break;
                    }       // switch
                }       // loop
                Console.WriteLine();
            }       // loop: 현재 보드의 상태를 출력
            Console.WriteLine();
            // } 현재 보드의 상태를 플레이 시점으로 보여준다

            if (isPlayerWin)
            {
                Console.WriteLine("[플레이어] 지뢰를 모두 찾고 승리했습니다.");
            }
            else
            {
                Console.WriteLine("[플레이어] 지뢰를 밟고 패배했습니다.");
            }
        }       // MineGame()
        #endregion      // #region Chapter 02 Lab

        #region Chapter 02 programming exercise
        /**
         * 사용자로부터 2개의 문자열을 읽어서 같은지 다른지 출력하는 프로그램
         * 단, string.Equals() 등 기존에 제공되는 문자열 메서드로 처리하면 안됨.
         * 반드시 루프를 사용할 것
         */
        public static void IsStringSame()
        {
            string strFirst = string.Empty;
            string strSecond = string.Empty;

            Console.Write("첫 번째 문자열: ");
            strFirst = Console.ReadLine();
            Console.Write("두 번째 문자열: ");
            strSecond = Console.ReadLine();

            bool isSameStr = true;
            if (strFirst.Length.Equals(strSecond.Length) == false) { isSameStr = false; }
            else
            {
                for (int index = 0; index < strFirst.Length; index++)
                {
                    if (strFirst[index] == strSecond[index]) { continue; }
                    else
                    {
                        isSameStr = false;
                        break;
                    }
                }       // loop: 문자열의 길이만큼 루프
            }       // else: 두 문자열의 길이가 같은 경우

            if(isSameStr)
            {
                Console.WriteLine("2개의 문자열은 같습니다.");
            }
            else
            {
                Console.WriteLine("2개의 문자열은 다릅니다.");
            }
        }       // IsStringSame()

        /**
         * 5개의 음료를 판매하는 자동판매기 머신
         * 사용자는 1~5 사이의 숫자를 입력. 음료수를 선택.
         * 사용자가 선택한 음료를 출력. 1~5 이외의 숫자를 선택하면
         * "오류. 선택이 유효하지 않습니다. 돈을 반환합니다."라는 내용을 출력.
         * (콜라, 물, 스프라이트, 주스, 커피)
         */
        public static void DrinkVendingMachine()
        {
            int pickedDrink = 0;
            Console.WriteLine("콜라, 물, 스프라이트, 주스, 커피 중에서 하나를 선택하세요.");
            Console.Write("(1. 콜라, 2. 물, 3. 스프라이트, 4. 주스, 5. 커피): ");
            int.TryParse(Console.ReadLine(), out pickedDrink);

            switch(pickedDrink)
            {
                case 1:
                    Console.WriteLine("콜라를 선택하였습니다.");
                    break;
                case 2:
                    Console.WriteLine("물을 선택하였습니다.");
                    break;
                case 3:
                    Console.WriteLine("스프라이트를 선택하였습니다.");
                    break;
                case 4:
                    Console.WriteLine("주스를 선택하였습니다.");
                    break;
                case 5:
                    Console.WriteLine("커피를 선택하였습니다.");
                    break;
                default:
                    Console.WriteLine("오류. 선택이 유효하지 않습니다. 돈을 반환합니다.");
                    break;
            }       // switch
        }       // DrinkVendingMachine()

        /**
         * 배열 days[]를 아래와 같이 초기화하고 배열 요소의 값을 다음과 같이 출력하는 프로그램
         * {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
         * ex) "7월은 31일까지 있습니다."
         */
        public static void MonthAndDays()
        {
            int[] days = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            
            for(int index = 0; index < days.Length; index++)
            {
                Console.WriteLine($"{index + 1}월은 {days[index]}일까지 있습니다.");
            }       // loop
        }       // MonthAndDays()

        /**
         * 사용자가 정수를 5번 입력하는 프로그램
         * 5를 한번도 입력하지 않은 경우 "인내심이 강합니다. 사용자 승" 출력
         * 5를 입력한 경우 "5를 입력하였군요! 컴퓨터 승" 출력
         */
        public static void InputNumber5()
        {
            int number = 0;
            bool isPlayerWin = true;

            for (int index = 0; index < 5; index++)
            {
                Console.Write("정수를 입력하시오: ");
                int.TryParse(Console.ReadLine(), out number);

                if(number.Equals(5))
                {
                    isPlayerWin = false;
                    break;
                }
                else { continue; }
            }       // loop

            if (isPlayerWin)
            {
                Console.WriteLine("인내심이 강합니다. 사용자 승");
            }
            else
            {
                Console.WriteLine("5를 입력하였군요! 컴퓨터 승");
            }
        }       // InputNumber5()

        /**
         * 사용자로부터 정수를 입력받아서 계속 더하는 프로그램
         * 사용자가 0을 입력하면 지금까지 입력된 모든 정수의 합을 출력하고 종료
         */
        public static void SumOfNumbers()
        {
            int number = 0;
            int sumOfNumbers = 0;

            while (true)
            {
                Console.Write("정수를 입력하시오: ");
                int.TryParse(Console.ReadLine(), out number);

                if (number.Equals(0)) { break; }
                else { /* Do nothing */ }
                sumOfNumbers += number;
            }       // loop
            Console.WriteLine("합계: {0}", sumOfNumbers);
        }       // SumOfNumbers()

        /**
         * 계단식으로 숫자를 출력하는 프로그램
         * ex)
         * 1******
         * 12*****
         * ...
         * 1234567
         */
        public static void CascadeNumbers()
        {
            for(int y = 0; y < 7; y++)
            {
                for(int x = 0; x < 7; x++)
                {
                    if(y < x)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write($"{x + 1}");
                    }
                }
                Console.WriteLine();
            }       // loop
        }       // CascadeNumbers()

        /**
         * 1~100 까지의 자연수 중에서 3의 배수를 출력
         */
        public static void MultipleThree()
        {
            for(int index = 1; index <= 100; index++)
            {
                if(index % 3 == 0)
                {
                    Console.Write("{0} ", index);
                }
                else { /* Do nothing */ }

                if(index % 30 == 0)
                {
                    Console.WriteLine();
                }
                else { /* Do nothing */ }
            }       // loop
        }       // MultipleThree()

        /**
         * 사용자가 입력한 정수의 모든 약수를 화면에 출력하는 프로그램
         */
        public static void DivisorElements()
        {
            int number = 0;
            Console.Write("정수를 입력하시오: ");
            int.TryParse(Console.ReadLine(), out number);

            int printCnt = 0;
            for(int numberDivisor = number; 0 < numberDivisor; numberDivisor--)
            {
                if (printCnt % (10 + 1) == 0)
                {
                    Console.WriteLine();
                    printCnt++;
                }
                else { /* Do nothing */ }

                if (number % numberDivisor == 0)
                {
                    Console.Write("{0} ", numberDivisor);
                    printCnt++;
                }
                else { continue; }
            }       // loop: 약수를 찾는 루프
        }       // DivisorElements()

        /**
         * 화시 온도 0도 ~ 100까지의 구간을 10도 간격으로
         * 섭씨 온도로 환산하는 표를 출력하는 프로그램
         * c = (f - 32.0) * 5.0 / 9.0
         */
        public static void FahrenheitToCelsius()
        {
            for(int fTemper = 0; fTemper <= 100; fTemper += 10)
            {
                Console.WriteLine("{0}{1:F2}", $"{fTemper}".PadRight(8, ' '),
                    (fTemper - 32.0F) * 5.0F / 9.0F);
            }
        }       // FahrenheitToCelsius()

        /**
         * 피타고라스의 정리
         * 직각 삼각형에서 빗변의 길이 c에 대해서 직각을 낀 두 변 a, b 일 때
         * a^2 + b^2 = c^2
         * 각 변의 길이가 100보다 작은 삼각형 중에서 피타고라스의 정리가 성립하는 삼각형은
         * 몇 개가 있는지?
         */
        public static void PythagorasTriangle()
        {
            Console.WriteLine("피타고라스의 정리가 성립하는 삼각형 \n");

            for(int sideA = 1; sideA <= 100; sideA++)
            {
                for(int sideB = 1; sideB <= 100; sideB++)
                {
                    for(int hypotenus = 1; hypotenus <= 100; hypotenus++)
                    {
                        if((sideA * sideA + sideB * sideB).Equals(hypotenus * hypotenus))
                        {
                            Console.WriteLine("{0} {1} {2}", sideA, sideB, hypotenus);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }       // loop: 빗변의 길이가 맞는지 확인한다
                }
            }       // loop
        }       // PythagorasTriangle()

        /**
         * 임의의 정수 n을 입력받음
         * 1~n 각 수의 제곱을 모두 더한 값을 출력
         */
        public static void SumOfCascadeSquare()
        {
            int number = 0;
            int sumOfValues = 0;
            Console.Write("임의의 정수 N의 값을 입력: ");
            int.TryParse(Console.ReadLine(), out number);

            for(int index = 1; index <= number; index++)
            {
                sumOfValues += (index * index);
            }       // loop
            Console.WriteLine("계산값은 {0}입니다.", sumOfValues);
        }       // SumOfCascadeSquare()

        /**
         * 3-6-9 게임
         * 1~100까지 수를 센다. 중간에 3의 배수가 나오면 "박수" 출력
         * 나머지 수는 그냥 숫자로 출력
         */
        public static void TheGame369()
        {
            for(int index = 1; index <= 100; index++)
            {
                if(index % 3 == 0)
                {
                    Console.Write("박수 ");
                }
                else
                {
                    Console.Write("{0} ", index);
                }

                if(index % 20 == 0)
                {
                    Console.WriteLine();
                }
                else { /* Do nothing */ }
            }       // loop
        }       // TheGame369()

        /**
         * 피보나치 수열을 계산하는 프로그램
         * 피보나치 수열은 0과 1부터 시작하며 앞의 두 수를 더하여 뒤의 수를 만든다
         */
        public static void FibonacciNumbers()
        {
            //int fibonacciRank
            //Console.Write("몇 항까지 구할까요: ");
            
        }       // FibonacciNumbers()
        #endregion      // Chapter 02 programming exercise
    }       // Program class
}