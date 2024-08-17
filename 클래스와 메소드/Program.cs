using System.Drawing;
using 메이플스토리;

namespace 클래스와_메소드
{
    internal class Program
    {
        static void PlayerTurn(Player player, Slime slime)
        {
            Console.WriteLine("1. 공격한다.");
            Console.WriteLine("2. 휴식한다.");
            Console.WriteLine("유저의 행동을 입력해주세요");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                player.Attack(slime);
            }
            else if (userInput == 2)
            {
                player.Rest();
            }
        }

        static void Main(string[] args)
        {
            네임스페이스 ns = new 네임스페이스();
            ns.Show();

            /*
             *  클래스 사용하는 방법
             *  (이름공간.Slime) (클래스의 이름 변수) = new 메이플스토리.Slime(); 
             */ 

            메이플스토리.Slime slime = new 메이플스토리.Slime();
            slime.Name = "슬라임";
            slime.HP = 50;
            slime.AttackPower = 5;
            slime.MoveSpeed = 2.2f;
            slime.Show();

            메이플스토리.Player player = new 메이플스토리.Player();
            player.HP = 100;
            player.AttackPower = 10;

            slime.Attack(player);                          //  Attack() 메소드는 인자로 Player 객체를 받는다. player
            slime.BeAttacked(player.AttackPower);          // BeAttacked() 메소드는 인자로 Int 데이터를 받는다. (int)player.AttackPower
            slime.Show();

            //player.Show();

            while(true) // 무한 반복문
            {
                PlayerTurn(player, slime); // 함수로 코드를 정리해서, 코드의 쓰임새를 쉽게 정리할 수 있다.

                slime.Attack(player);
                player.Show();
                slime.Show();
                //EnemyTurn(player, slime);  // 적이 플레이어를 대상으로 하는 행동 AI

                if(slime.HP <= 0)
                {
                    Console.WriteLine("슬라임을 처치했습니다. 게임에서 승리했습니다.");
                    break;
                }

                if(player.HP <= 0)
                {
                    Console.WriteLine("플레이어가 사망했습니다. 게임에서 패배했습니다.");
                    break;
                }
            }
        }
    }
}
