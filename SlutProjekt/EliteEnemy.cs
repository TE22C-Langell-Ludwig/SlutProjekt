using SlutProjekt;

public class EliteEnemy : Enemy
{
    private bool IsShielded;
    public EliteEnemy(int Hp, int Atk, bool _IsShielded) : base( Hp, Atk)
    {
      IsShielded = _IsShielded;

    }
}
