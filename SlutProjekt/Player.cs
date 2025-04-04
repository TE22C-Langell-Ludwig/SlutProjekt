using System;

namespace SlutProjekt;

public class Player
{
  public int hp;
  public int atk;
  public bool AttackingAir;
  public Player(int Hp, int Atk, bool _AttackingAir)
  {
    hp = Hp;
    atk = Atk;
    AttackingAir = _AttackingAir;
  }
}



