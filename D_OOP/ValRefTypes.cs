namespace D_OOP;

//Структура содержащая ссылочные типы
public struct EvilStrict
{
    public int x;
    public int y;

    public PointRef PointRef;
}

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
public class PointRef
{
    public int x;
    public int y;

    public void LogValues()
    {
        Console.WriteLine($"X={x}");
        Console.WriteLine($"Y={y}");
    }
}