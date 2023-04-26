// See https://aka.ms/new-console-template for more information

using System;

namespace CSharp
{
    class Program
    {
        //void = "типизаци" функция ничего не возвращает
        static void Main(string[] args)
        {
            int x = -1;

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

            Console.WriteLine(name);
        }
    }
}

