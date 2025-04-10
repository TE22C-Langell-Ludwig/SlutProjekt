using System;

namespace SlutProjekt;

public class Player : Living
{
  public bool AttackingAir;
  public Player(int Hp, int Atk, bool _AttackingAir) : base(Hp,Atk)
  {
    hp = Hp;
    atk = Atk;
    AttackingAir = _AttackingAir;
  }
}



