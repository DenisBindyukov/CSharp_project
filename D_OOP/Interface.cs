namespace D_OOP;

// Все интерфэйсы по соглашению между програмистами начинаються с заглавной буквы I
public interface ICollection
{
    void Add(object obj);
    void Remove(object obj);
}

public interface ICollectionTwo
{
    void Delete(object obj);
    void Update(object obj);
}

public class BaseList
{
}

public class BaseCollection : ICollection, ICollectionTwo
{
    private object[] items;
    private int count = 0;

    //Конструктор данного класса
    public BaseCollection(int initialCapacity)
    {
        this.items = new Object[initialCapacity];
    }
     

    public void Add(object obj)
    {
        items[this.count] = obj;
        this.count++;
        Console.WriteLine(this.count);
    }

    public void Remove(object obj)
    {
    }

    public void Delete(object obj)
    {
    }

    public void Update(object obj)
    {
    }
}

//show
//can't inherit from multiple classes
//but can inherit from one class and multiple interfaces
//or from just multiple interfaces
public class MyList : ICollection
    //IDisposable, ISerializable
{
    public void Add(object obj)
    {
        //implementation
    }

    public void Remove(object obj)
    {
        //implementation
    }
}


//Расширение интерфейса ICollection
public static class ICollectionExt
{
    public static void AddRange(this ICollection collection, IEnumerable<object> objects)
    {
        foreach (var item in objects)
        {
            collection.Add(item);
        }
    }
}
