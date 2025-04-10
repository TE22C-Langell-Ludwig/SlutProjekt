namespace SlutProjekt;

public class Enemy : Living
{
    public string name;
    public Enemy(int Hp, int Atk, string Name) : base(Hp,Atk)
    {
        name = Name;
    }

    public int Attack(int hp)
    {
        hp -= atk;
        return hp;
    }

    public virtual void Gethit(int atk, bool AttackingAir)
    {
        if (AttackingAir!=true){
        hp -= atk;
        }
        else if (AttackingAir==true){
        Console.WriteLine($"You swing Above {name}'s head and miss. (Hint. only flying enemies can be in the air)");
        }
    }

}
