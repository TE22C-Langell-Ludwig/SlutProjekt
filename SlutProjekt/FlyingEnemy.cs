using System;

namespace SlutProjekt;

public class FlyingEnemy : Enemy
{
  private bool IsFlying;
  public FlyingEnemy(int Hp, int Atk, string Name, bool _IsFlying) : base(Hp, Atk, Name)
  {
    IsFlying = _IsFlying;

  }

  public override void Gethit(int atk, bool AttackingAir)
  {
    if (AttackingAir == IsFlying)
    {
      hp -= atk;
    }
    else
    {
      Console.WriteLine("You attack the wrong position and miss");
    }

  }
  public override string GetEnemyType()
    {
    string CurrentEnemyType="Flying Enemy";
    return CurrentEnemyType;
    }









}
