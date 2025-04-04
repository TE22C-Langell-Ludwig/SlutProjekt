using System.Reflection.Metadata.Ecma335;
using SlutProjekt;
List<string> Names = new List<string>();

Names.Add("Jim");
Names.Add("Jeremy");
Names.Add("George");
Names.Add("Jerry");
Names.Add("Ben");
Names.Add("Todd");
Names.Add("Brian");


Queue<Enemy> EnemyQueue = new Queue<Enemy>();
for (int EnemyCount = 0; EnemyCount < 10; EnemyCount++)
{
    int EnemyType = Random.Shared.Next(0, 3);
    string enemyname = Names[Random.Shared.Next(0, 7)];
    if (EnemyType == 0)
    {
        int EliteEnemyHp = Random.Shared.Next(10, 20) * 10;
        int EliteEnemyAtk = Random.Shared.Next(5, 10);
        Enemy Enemy1 = new Enemy(150, 5, enemyname);
        EnemyQueue.Enqueue(Enemy1);

    }
    if (EnemyType == 1)
    {
        int EliteEnemyHp = Random.Shared.Next(25, 35) * 10;
        int EliteEnemyAtk = Random.Shared.Next(10, 25);
        EliteEnemy Enemy1 = new EliteEnemy(EliteEnemyHp, EliteEnemyAtk, enemyname, false);
        EnemyQueue.Enqueue(Enemy1);
    }
    if (EnemyType == 2)
    {
        int FlyingEnemyHp = Random.Shared.Next(10, 16) * 10;
        int FlyingEnemyAtk = Random.Shared.Next(5, 15);
        bool FlyingEnemyFlyingBool = false;
        int FlyingEnemyFlyingInt = Random.Shared.Next(0, 2);
        if (FlyingEnemyFlyingInt == 0)
        {
            FlyingEnemyFlyingBool = true;
        }
        if (FlyingEnemyFlyingInt == 1)
        {
            FlyingEnemyFlyingBool = false;
        }
        FlyingEnemy Enemy1 = new FlyingEnemy(FlyingEnemyHp, FlyingEnemyAtk, enemyname, FlyingEnemyFlyingBool);
        EnemyQueue.Enqueue(Enemy1);
    }
}







Player Main = new Player(30000, 15, false);
bool ChoosingAttack = true;

while (Main.hp > 0)
{
    while (ChoosingAttack == true)
    {
        Console.WriteLine("Choose What Area you want to attack A. The air B. The ground");
        string answer = Console.ReadLine().ToUpper();
        if (answer == "A")
        {
            Main.AttackingAir = true;
            ChoosingAttack = false;

        }
        else if (answer == "B")
        {
            Main.AttackingAir = false;
            ChoosingAttack = false;

        }
        else
        {
            Console.WriteLine("Non-Eligible Choice Pick Again.");
        }
    }
    EnemyQueue.Peek().Gethit(Main.atk, Main.AttackingAir);
    Main.hp = EnemyQueue.Peek().Attack(Main.hp);
    if (EnemyQueue.Peek().hp > 0 && EnemyQueue.Peek() is not EliteEnemy)
    {

        Console.WriteLine($"{EnemyQueue.Peek().name} has {EnemyQueue.Peek().hp} Hp left");
        Console.WriteLine($"you have {Main.hp} Hp left");
        Console.ReadLine();
    }
    else if (EnemyQueue.Peek().hp > 0 && EnemyQueue.Peek() is EliteEnemy)
    {

        Console.WriteLine($"you have {Main.hp} Hp left");
        Console.ReadLine();
    }
    if (EnemyQueue.Peek().hp <= 0)
    {
        Console.WriteLine($"Enemy has been Defeated, Enemy Reinforcements are arriving");
        Console.WriteLine($"Press Enter to proceed");
        EnemyQueue.Dequeue();
        Console.ReadLine();
    }
    ChoosingAttack = true;
    Console.Clear();
}
























