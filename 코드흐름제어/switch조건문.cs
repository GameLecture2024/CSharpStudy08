using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    enum USERINPUT { GAMESTART = 1, GAMEEND, OPTION}
    // enum : 열거형. 
    // 숫자 1이 무조건 A를 표현할거야. 약속.
  

    internal static class switch조건문
    {
        static USERINPUT userEnumInput;
        public static void Show()
        {
            Console.WriteLine("switch 조건문 강의");

            // if ~ else if ~ else if ~ else if ~ else if ~ else if ~ else if 코드 내용을 파악하기 힘들었다.
            int userInput = int.Parse(Console.ReadLine()); // 1번 게임시작, 2번 게임종료 3번 옵션

            switch (userInput) // switch case를 판별할 변수
            {
                case 1:
                    Console.WriteLine("1번 게임시작");
                    break;
                case 2:
                    Console.WriteLine("2번 게임종료");
                    break;
                case 3:
                    Console.WriteLine("3번 옵션");
                    break;
                default:
                    Console.WriteLine("잘못 입력했습니다. 다시 입력해주세요.");
                    break;
            }

            // if(userInput ==1)
            // switch문 사용시 주의 사항
            // break 사용법을 주의해야한다.


        }
    }
}
