using System;

namespace SlutProjekt;

public class FlyingEnemy : Enemy
{
private bool IsFlying;
 public FlyingEnemy(int Hp, int Atk, string Name, bool _IsFlying) : base( Hp, Atk, Name)
    {
      IsFlying = _IsFlying;

    }
    
}
