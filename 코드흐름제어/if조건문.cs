using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    // static 키워드를 선언하면..
    // 클래스의 인스턴스가 아니라 객체 그 자체에 접근하게 한다.
    // if조건문.Show();
    static class if조건문
    {
        public static void Show() // 강의 내용을 출력하는 메소드
        {
            Console.WriteLine("if조건문");

            // 1. 위에서 부터 순서대로 실행되는 구조가 아닌 선택으로 실행되는 코드의 흐름 제어
            // 1-1 조건식 : 조건문을 실행할지 말지 결정하는 문

            // true, false 조건문에 직접 할당.
            // true: 실행된다. false 실행이 안된다.
            if (false)
            {
                Console.WriteLine("if문이 실행됨");
            }

            int num = int.Parse(Console.ReadLine());
            if(num > 5) 
            {
                Console.WriteLine("num이 5보다 큽니다.");
            }
            else // if와 함께 사용해야하며, 위의 if조건문이 아닐 때 실행한다.
            {
                Console.WriteLine("num이 5보다 작거나 같습니다.");
            }
            // 2. if 조건문 사용 시 주의해야 할 사항

            Console.Write("숫자를 입력해주세요 : ");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 > 5); // 해당 문장이 여기서 끝난다.
            {
                Console.WriteLine("num2가 5보다 큽니다.");
            }

            // 3. if 조건문 사용 시 혼동이 가는 부분
            if(num2 > 5)
                Console.WriteLine("조건문이 한줄인 경우에는 중괄호 없이 표현할 수 있다.");
            else
                Console.WriteLine("num가 5보다 작거나 같습니다.");

            // 4. 중괄호 없이 if문을 사용할 때 주의해야할 사항

            if(num2 > 5)
                Console.WriteLine("num2가 5보다 큽니다.");      // 조건문의 영향을 받는다.
                Console.WriteLine("그리고 이것도 출력됩니다.");  // 조건문과 상관없이 항상 실행된다.

            // 5. 조건이 여러개일 경우에는 어떻게 표현하면 되나요?

            Console.WriteLine("입력 값을 넣어주세요(1 : 게임시작, 2: 게임종료 3: 옵션) : ");
            int userInput = int.Parse(Console.ReadLine()); // 1. 게임 시작 2. 게임 종료 3. 옵션

            if(userInput == 1) // 입력받은 숫자가 1일 때 true
            {
                Console.WriteLine("1. 게임 시작");
            }
            else if(userInput == 2) // else if 계속해서 추가할 수 있다.
            {
                Console.WriteLine("2. 게임 종료");
            }
            else if(userInput == 3)
            {
                Console.WriteLine("3. 옵션");
            }
            else
            {
                Console.WriteLine("잘못된 입력 값입니다. 다시 입력해주세요.");
            }
        }
    }
}
