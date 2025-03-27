using System;

namespace SlutProjekt;

public class FlyingEnemy : Enemy
{
private bool IsFlying;
 public FlyingEnemy(int Hp, int Atk, bool _IsFlying) : base( Hp, Atk)
    {
      IsFlying = _IsFlying;

    }
}
