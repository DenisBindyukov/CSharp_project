// See https://aka.ms/new-console-template for more information

using System;
using D_OOP;

namespace CSharp
{
    class Program
    {
        //void = "типизаци" функция ничего не возвращает
        static void Main(string[] args)
        {
            /*int x = -1;

            int y;
            y = 2;

            var x1 = -1;

            //uint z = -1;

            float f = 1.1f;
                
            double d = 2.3;

            int x2 = 0;
            int x3 = new int();

            var number = 1;
            var b = 1.2;

            var dictionary = new Dictionary<int, string>();

            Console.WriteLine(number);

            //var v;

            decimal money = 3.0m;

            //символ (заключается в одинарные ковычки)
            char character = 'A';
            
                //стринга в двойные ковычки
            string name = "John";

            bool booolean = true;
            
            //cw CONSOLE.LOG() 
            

            Console.WriteLine(name);*/
            //Console.WriteLine();

            //********************************************************//

            //ArrayDemo();
            //Cycles();
            //Collection_Arrays();
            Collection_List();
            //Dictionary();
            //MultidimensionalArrays();
            // Character character = new Character();
            // character.Hit(5);
        }

        static void ArrayDemo()
        {
            int[] a1 = new int[10];
            int[] arr = new[] { 12, 23, 45, 43 };
            int[] arr2 = { 12, 23, 45, 43 };

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine(arr2.Length);
            Console.WriteLine(arr2[arr2.Length - 1]);

            string str = "abcdf";
            char first = str[0];
            char last = str[str.Length - 1];
            Console.WriteLine($"First: {first}. Last: {last}");
        }

        static void Cycles()
        {
            int[] arr2 = { 12, 23, 45, 43 };

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            //foreach не имеет доступ к индексу, имеет доступ сразу к значению.
            foreach (var val in arr2)
            {
                Console.WriteLine(val);
            }
        }

        static void Collection_Arrays()
        {
            //BinarySearch быстро находит по заданному массиву и поисковому числу индекс элемента 
            //работает только по упорядоченному массиву.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = Array.BinarySearch(numbers, 8);
            Console.WriteLine(index);

            //Копирование массива
            int[] arrayCope = new int[numbers.Length];
            numbers.CopyTo(arrayCope, 0);
            Console.WriteLine(arrayCope[1]);

            Array.Reverse(arrayCope);
            foreach (var item in arrayCope)
            {
                Console.WriteLine(item);
            }

            Array.Sort(arrayCope);
            foreach (var item in arrayCope)
            {
                Console.WriteLine(item);
            }
        }

        static void Collection_List()
        {
            var intList = new List<int>() { 2, 3, 2, 4, 5, 6, 7 };
            intList.Add(1123);
            intList.Add(11223);


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            intList.AddRange(numbers);

            Console.WriteLine(intList.Count);

            if (intList.Remove(
                    -1)) //удаляет элемент при первом вхождении, как и find  не итерирует массив после первого совпадения.
            {
                Console.WriteLine(intList.Count);
            }
            else
            {
                intList.RemoveAt(0); //Удаляет элемент по индексу.

                bool contains =
                    intList.Contains(11223); //Содержит ли List элемент 11223 в массиве, возвращает булевское значение.

                int min = intList.Min(); //Находит минамальное число в массиве.
                int max = intList.Max(); // Находит Максимальное число в массиве.

                Console.WriteLine(min);
                Console.WriteLine(max);

                int indexOf = intList.IndexOf(9);
                int lastIndexOf = intList.LastIndexOf(2);

                for (int i = 0; i < intList.Count; i++)
                {
                    int result = intList[i];

                    Console.WriteLine(result);
                }

                foreach (var item in intList)
                {
                    Console.WriteLine($"foreach result {item}");
                }
            }
        }

        static void Dictionary()
        {
            // ***** Associative array ***** //

            var people = new Dictionary<int, string>();

            for (int i = 0; i < 10; i++)
            {
                people.Add(i, $"John_{i}");
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(people[9]);

            //Ключи должны быть уникальными в Dictionary, иначе будет исключение
            people = new Dictionary<int, string>()
            {
                { 1, "George" },
                { 2, "Kurt" },
                { 3, "Miles" },
            };

            Console.WriteLine(people.Count);
            //поиск по ключу в ассицоативном массиве
            Console.WriteLine(people[2]);

            //Итерация по ключам
            var keys = people.Keys;
            foreach (var item in keys)
            {
                Console.WriteLine($"key: {item}");
            }

            //Итерация по значениям
            var values = people.Values;
            foreach (var item in values)
            {
                Console.WriteLine($"value: {item}");
            }

            //Итерация по ассоциативный массиву.
            foreach (var pair in people)
            {
                Console.WriteLine($"Key: {pair.Key}; Value: {pair.Value}");
            }

            //Поиск элемента по ключу.
            bool containsKey = people.ContainsKey(2);

            //Поиск элемента по значению.
            bool containsValue = people.ContainsValue("Miles");

            Console.WriteLine($"Contains key:{containsKey}. Contains value:{containsValue}");

            //Удаляет элемент по ключу.
            bool itemWasDelete = people.Remove(2);

            if (itemWasDelete)
            {
                Console.WriteLine("Kurt was delete");
            }

            //TryAdd Метод позваляет добавить по ключи элемент, если элемент по ключу уже существует вернеться false
            if (people.TryAdd(1, "Nikita"))
            {
                Console.WriteLine("Added seccessfully");
            }
            else
            {
                Console.WriteLine("Failed to add using key 1");
            }

            // TryGetValue метод позволяет получить элемент по ключу, если элемент найден, будет помещен в переменную val (out это тип)
            if (people.TryGetValue(1, out string val))
            {
                Console.WriteLine($"find element by key 1 {val}");
            }
            else
            {
                Console.WriteLine("Failed to get");
            }
        }

        static void MultidimensionalArrays()
        {
            //Многомерные массивы

            //Двух уровневый массив
            //1 2 3
            //4 5 6

            int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //короткий синтаксис создания (Двух уровневый массив) С# сам проанализирует int в момент инициализации
            int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Проход по двух уровнему массиву.
            //в метод GetLength(0) передаеться число с указанием конкретной длинный строки двух уровневого массива
            //нумерация строк совпадает в точности с индексами
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    //i = являеться строкой
                    //j =  являеться столбцом
                    //Первый цыкл запускает обход по строке, где j уже пробегает по строке выводя значения (т.е столбцы)
                    // Следовательно второй проход цыкла i запускает второю строку
                    Console.Write($"{r2[i, j]}");
                }
            }
        }
    }
}