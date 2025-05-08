using SlutProjekt;

public class EliteEnemy : Enemy
{
  private bool IsShielded;
  int hitcount = 0;
  public EliteEnemy(int Hp, int Atk, string Name, bool _IsShielded) : base(Hp, Atk, Name)
  {
    IsShielded = _IsShielded;

  }
  public override void Gethit(int atk, bool AttackingAir)
  {
    if (AttackingAir!=true){
    if (IsShielded == false)
    {
      hp -= atk;
      ++hitcount;
      Console.WriteLine($" {name} has {hp} Hp left");
    }
    if (IsShielded == true)
    {
      Console.WriteLine($"The Fierce enemy toughed through your attack and was unschated. {hp} hp Left");
      IsShielded = false;
    }
    if (hitcount == 2)
    {
      IsShielded = true;
      hitcount = 0;
    }
    }
    else if (AttackingAir==true){
    Console.WriteLine($"You swing Above {name}'s head and miss. (Hint. only flying enemies can be in the air)");
    }






  }
  public override string GetEnemyType()
    {
    string CurrentEnemyType="Elite Enemy";
    return CurrentEnemyType;
    }
}
