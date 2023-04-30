namespace D_OOP;

// Все типы "value types" т.е типы значений.
public struct PointVal
{
    public int x;
    public int y;

    public void LogValues()
    {
        Console.WriteLine($"X={x}");
        Console.WriteLine($"Y={y}");
    }
}

//Все классы ссылочные типы.
public struct PointRef
{
    public int x;
    public int y;

    public void LogValues()
    {
        Console.WriteLine($"X={x}");
        Console.WriteLine($"Y={y}");
    }
}