namespace D_OOP;

public class Character
{
    //private - нельзя объявить класс как private, только мотоды и свойства
    //public
    //internal - доступен только в сборке в которой он определен
    //protected - нельзя объявить класс как protected, только мотоды и свойства
    //private int health = 100;

    // public int Health
    // {
    //     get
    //     {
    //         return health;
    //     }
    //     private set
    //     {
    //         health = value;
    //     }
    // }
    private static int speed = 10;

    public int Health { get; private set; } = 100;

    public void Hit(int damage)
    {
        if (damage > Health)
        {
            damage = Health;
        }

        //health -= damage;
        Health -= damage;
    }

    public int PrintSpeed()
    {
        return speed;
    }

    public void IncreaseSpeed()
    {
        speed += 10;
    }
}