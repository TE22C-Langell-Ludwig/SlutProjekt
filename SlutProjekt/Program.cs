using SlutProjekt;

for (int EnemyCount = 0; EnemyCount < 10; EnemyCount++)
{
int EnemyType = Random.Shared.Next(0,3);
if (EnemyType==0)
{
Enemy basic = new Enemy (150, 5);
}
if (EnemyType==1)
{

}
if (EnemyType==2)
{

}

}







Player Main = new Player(100,15,false);
Enemy basic = new Enemy (150, 5);
EliteEnemy jeremy = new EliteEnemy (300,10,false);
FlyingEnemy jim = new FlyingEnemy(100,15,true);
Queue<Enemy> EnemyQueue = new Queue<Enemy>();

EnemyQueue.Enqueue(basic);
EnemyQueue.Enqueue(jim);
EnemyQueue.Enqueue(jeremy);



while (Main.hp>0)
{

EnemyQueue.Peek().Gethit(Main.atk);
Main.hp=EnemyQueue.Peek().Attack(Main.hp);
if (EnemyQueue.Peek().hp>0)
{

Console.WriteLine($" The enemy has {EnemyQueue.Peek().hp} Hp left");
Console.WriteLine($" you have {Main.hp} Hp left");
Console.ReadLine();
}
if (EnemyQueue.Peek().hp<=0)
{
Console.WriteLine($"Enemy has been Defeated, Enemy Reinforcements are arriving");
Console.WriteLine($"Press Enter to proceed");
EnemyQueue.Dequeue();
Console.ReadLine();
}




}
























