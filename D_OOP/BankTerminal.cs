namespace D_OOP;


//НАСЛЕДОВАНИЕ
public class BankTerminal
{
    public readonly string id;
    
    //constructor
    public BankTerminal(string id)
    {
        this.id = id;
    }

    
    //virtual позволяет переопределить метод в дочерних классах
    public virtual void Connect()
    {
        Console.WriteLine("General Connecting Protocol");
    }
}

public class ModelXTerminal : BankTerminal
{
    //constructor
    public ModelXTerminal(string id) : base(id)
    {
    }
    public override void Connect()
    {
        base.Connect();
        Console.WriteLine("Additional actions for Model X");
    }
}

public class ModelYTerminal : BankTerminal
{
    //constructor
    public ModelYTerminal(string id) : base(id)
    {
    }
    public override void Connect()
    {
        Console.WriteLine("Additional for Model Y");
    }
}