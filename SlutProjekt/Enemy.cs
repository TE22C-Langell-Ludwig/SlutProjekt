namespace SlutProjekt;

public class Enemy
{
    public int atk;
    public int hp;
    public Enemy(int Hp, int Atk)
    {
        hp = Hp;
       atk = Atk;
    }

    public int Attack(int hp)
    {
        hp -= atk;
        return hp;
    }

    public void Gethit(int atk)
    {
        hp -= atk;
    }

}
