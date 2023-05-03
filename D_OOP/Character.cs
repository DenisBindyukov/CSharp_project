namespace D_OOP;

public  class Character
{
    //private - нельзя объявить класс как private, только мотоды и свойства
    //public
    //internal - доступен только в сборке в которой он определен
    //protected - нельзя объявить класс как protected, только методы и свойства
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
    private readonly int speed;
    
    //Отличие между const и readonly  в том что при инициализации поля const, необходимо присваивать состояния в момент инициальзации,
    //при объясвлении readonly, нет необходимомости задовать значение в момент инициализации 
    //private const int _speed;

    public string Race { get; private set; }
    public int Armor { get; private set; }

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
       // speed += 10;
    }

    public Character(string race,int speed, int armor = 100)
    {
        //КОНСТРУКТОР В КЛАССЕ ПО УМОЛЧАНИЮ (Т.Е. название самого класса)
        // конструкторы призваны защищать начальное состояние объекта
        this.Race = race;
        this.Armor = armor;
        this.speed = speed;
    }
}