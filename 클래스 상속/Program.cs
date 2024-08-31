namespace 클래스_상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클래스 상속");

            Player player = new Player();
            player.HP = 100;
            player.AttackPower = 10;

            Slime slime = new Slime();
            slime.HP = 50;
            slime.AttackPower = 5;

            Bear bear = new Bear();
            bear.HP = 30;
            bear.AttackPower = 3;

            player.Attack(bear);
            slime.Attack(player);

            bear.Attack(player);

            slime.SpecialAttack(); // 슬라임이 분열했다.
            bear.SpecialAttack();  // 곰이 울부짖었다.


            Parent parent = new Child(2, 3);
            parent.ShowInfo();
        }
    }
}
