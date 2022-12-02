using System;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForeachLoop();
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
        #endregion      // #region Chapter 02 Lab
    }       // Program class
}