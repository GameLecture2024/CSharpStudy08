// 주석 : 컴퓨터는 알아볼 수 없지만 사람만 알아볼 수 있게 표시하는 기능
// 1. // 해당 줄은 주석처리된다.(컴퓨터는 알아볼 수 없게 된다.)
// 2. /* */ : /* ~ */ 모두 주석 처리 하라

/*
 * 학습 목표 : CSharp 언어로 첫 프로그래밍 작성하기. 변수에 대한 이해
 * 작성일    : 2024-08-10
 * 작성자    : 김동훈
 */

/*
 * 프로그래밍 + 언어
 * 프로그래밍  : 컴퓨터로 프로그램을 작동시키는 작업
 * 언어        : 두 객체 사이에 대화를 하기 위한 도구
 * 프로그래밍 언어 : 컴퓨터와 사람이 대화를 하기 위해 필요한 언어다.
 * 
 * 사람은 기계가 하는 말을 알아들을 수 있습니까? -> X
 * 기계가 사람이 하는 말을 알아들을 수 있을까요? -> X
 * 번역기. 통역사 -> 컴파일러 : 사람과 컴퓨터 사이에 번역을 해주는 기계
 * C언어 C++언어 C#, 파이썬, 자바, 자바스크립트, 타입스크립트
 * .c .cpp .cs .py .jv .js .ty -> 번역기가 따로 있습니다.
 */

/*
 *  컴퓨터 사람이 사용하는 언어를 표현하는 방법을 모방하려면
 *  키워드? 
 *  이미 의미가 정해져 있는 단어.
 *  파란색으로 표시되어 있는 단어.
 *  흰색       : 어떤 것(데이터 타입)의 이름
 *  밝은 노란색 : 함수
 *  
 *   정수는 정수 방식으로 표현한다.
 *   실수는 실수 방식으로 표현한다.
 *   문자는 문자 방식으로 표현한다.
 *   
 *   정수 방식으로 사용하는 키워드 : int
 *   실수 방식으로 사용하는 키워드 : float
 *   단어 방식으로 사용하는 키워드 : char
 *   문자열 방식으로 사용하는 키워드 : string
 */

/*
 *  
 * 
 */

namespace CSharpStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("세계야 반갑다!");
            Console.WriteLine("컴퓨터에게 정수, 실수, 문자, 문자열을 입력시켜 본다.");

            // 변수 : 변하는 수. 출력할 때 값이 다를 수 있는 형태.
            // 변수의 선언
            // 키워드 해당키워드의 이름;
            // 키워드 : int(띄어쓰기)
            // 이름   : number
            // ;      : 세미클론. 해당 코드가 끝났다라는 사실을 알려주는 키워드.

            int number; // 정수를 저장할 수 있는 변수를 선언하는데 그 녀석의 이름이 number.
            number = 10; // number 변수에 10을 대입하라.

            // 정수형 변수로 이름을 num으로 선언해서 그 변수에 100이라는 숫자를 넣어보세요.
            int num;
            num = 100;

            // 초기화 : 변수의 선언과 동시에 데이터를 넣는 것
            int num2 = 200;

            Console.WriteLine(number);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(10);
            Console.WriteLine(100);
            Console.WriteLine(200);

            Console.WriteLine(10 + 100);
            int num3 = 10;
            int num4 = 20;
            // 정수의 사칙연산
            Console.WriteLine(num3 + num4);
            Console.WriteLine(num3 - num4);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num3 / num4);
            Console.WriteLine(num3 % num4);

            // 키워드를 하나 선택 float
            // 변수의 선언
            // 변수의 초기화
            // 변수의 사칙연산

            float f1 = 1.1f;
            float f2 = 2.3f;

            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(f1 % f2);
            char c1 = 'c';
            char c2 = 'u';

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
            Console.WriteLine(c1 % c2);
            // 문자는 사실 숫자입니다.
            // a라는 숫자를 46이다.
            // 46 -> a
            // ASCII 

            string s1 = "문자열";

            string s2 = "처음 만들어보는 C# 프로그램";
            string s3 = "3";
            string s4 = "5";
            Console.WriteLine(s3+s4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1 + s2);

            Console.Clear(); // 콘솔창을 비워주는 기능

            Console.WriteLine("두 수를 더해주는 프로그램입니다.");

            // 사용자의 입력을 받아서 두 수를 더하는 기능을 만들어 봅니다.
            // inputA 3, inputB 5 => 
            Console.Write("첫 번째 숫자를 입력해주세요 : ");
            string input; // 문자열을 저장할 수 있는 input이라는 변수를 선언한다.
            input = Console.ReadLine();
            // 문자를 숫자(int)로 바꾸는 방법(형변환)
            int inputNumber = int.Parse(input); // "3" -> 3 변환이 일어나는데, 저장을 안하고 있습니다.
            Console.Write("두 번째 숫자를 입력해주세요 : ");
            string inputA = Console.ReadLine();
            int inputNumber2 = int.Parse(inputA);
            Console.WriteLine("문자열의 덧셈 결과 : " + input + inputA);
            Console.WriteLine("정수의 덧셈 결과 : " + (inputNumber + inputNumber2));

            // "문자열" + 다른 숫자 => 정수의 덧셈 결과 : 숫자의 결과 값

            // 사용자의 입력을 받아서 두 수를 더하는 기능을 만들어 볼건데,
            // 실수형 타입(float)받아서 프로그램을 구성해보세요.
            Console.WriteLine("float 값 3개를 입력 받아서 더하는 프로그램");

            Console.Write("첫 번째 실수를 입력해주세요 : ");
            string floatInput; // 문자열을 저장할 수 있는 input이라는 변수를 선언한다.
            floatInput = Console.ReadLine();
            float floatNumber = float.Parse(floatInput); // "3" -> 3 변환이 일어나는데, 저장을 안하고 있습니다.
            Console.Write("두 번째 실수를 입력해주세요 : ");
            string floatInput2; // 문자열을 저장할 수 있는 input이라는 변수를 선언한다.
            floatInput2 = Console.ReadLine();
            float floatNumber2 = float.Parse(floatInput2); // "3" -> 3 변환이 일어나는데, 저장을 안하고 있습니다.
            Console.Write("세 번째 실수를 입력해주세요 : ");
            string floatInput3; // 문자열을 저장할 수 있는 input이라는 변수를 선언한다.
            floatInput3 = Console.ReadLine();
            float floatNumber3 = float.Parse(floatInput3); // "3" -> 3 변환이 일어나는데, 저장을 안하고 있습니다.
            Console.WriteLine("문자열의 덧셈 결과 : " + floatInput + floatInput2 + floatInput3);
            Console.WriteLine("정수의 덧셈 결과 : " + (floatNumber + floatNumber2 + floatNumber3));

            // 익숙해지기. int, float, char, string 입력을 받아서 출력해지는 것에.

            // 사각형의 넓이를 구하는 프로그램을 만들어 보겠습니다.

            Console.Write("가로의 크기를 입력해주세요 : ");
            string width = Console.ReadLine(); // 가로의 길이를 문자로 입력받아서. 정수형으로 변환을 해주세요
            int widthNumber = int.Parse(width);

            Console.Write("세로의 크기를 입력해주세요 : ");
            string height = Console.ReadLine(); // 세로의 길이를 입력받아서, 정수형으로 변환 해주세요.
            int heightNumber = int.Parse(height);

            Console.WriteLine($"사각형의 넓이 : {widthNumber * heightNumber}"); // 문자열 보간 중괄호 안에 변수를 입력하는 방식으로 문자열을 표현 '{}'


            // 원의 넓이를 구하는 프로그램도 하나 만들어 보세요
            // 반지름 * 반지름 * 3.14 

        }
    }
}
