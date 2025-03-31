namespace SlutProjekt;

public class Enemy
{
    public int atk;
    public int hp;
    public string name;
    public Enemy(int Hp, int Atk, string Name)
    {
        hp = Hp;
       atk = Atk;
       name = Name;
    }

    public int Attack(int hp)
    {
        hp -= atk;
        return hp;
    }

    public virtual void Gethit(int atk)
    {
        hp -= atk;
    }

}
