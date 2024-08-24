using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 코드흐름제어
{
    static class GameManager
    {
        public static void GameStart()
        {
            Console.WriteLine("게임이 시작했습니다.");

            while(true)
            {
                int a = int.Parse(Console.ReadLine());

                if(a == 0) // 0은 계속해서 실행한다.
                {
                    Console.WriteLine("게임 실행 중");
                }
                else if(a == 1) // 메뉴로 이동하라.
                {
                    Console.WriteLine("메뉴를 보여주세요.");
                    ShowMenu();
                }
            }
      
        }
        
        public static void LoadOptionTab()
        {
            Console.WriteLine("옵션 창을 불러왔습니다.");

            while (true)
            {
                int a = int.Parse(Console.ReadLine());

                //int.TryParse(Console.ReadLine(), out a); // 정수값만 입력할 수 있는 형태의 함수

                if (a == 0)
                {
                    Console.WriteLine("옵션 창중");
                }
                else if (a == 1)
                {
                    Console.WriteLine("메뉴를 보여주세요.");
                    ShowMenu();
                }
            }
        }

        public static void ShowMenu()
        {
            // 콘솔을 깨끗하게 정리해주세요.
            Console.Clear();
            Console.WriteLine("===========게임 메뉴 출력===========");
            Console.WriteLine("1. 게임 시작");
            Console.WriteLine("2. 옵션");
            Console.WriteLine("3. 게임 종료");

           
            // 1. 강의를 학습하고.. 스스로 이 코드를 직접 만들 수 있으면 성공적이다.

            while(true)
            {
                Console.WriteLine("입력을 기다리고 있습니다 : ");
                int userInput = int.Parse(Console.ReadLine());

                // 1. if 조건문, switch문

                if (userInput == 1)
                {
                    // 유니티에서 게임을 시작해주는 클래스와 메소드가 미리 구현이 되어있습니다.
                    Console.WriteLine("게임 시작!");
                    GameStart();
                    break;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("옵션!");
                    LoadOptionTab();
                    break;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("게임 종료!");
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                }
            }


        }
    }
}
