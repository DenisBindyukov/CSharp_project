namespace D_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Character character = new Character();
            // character.Hit(95);
            // Console.WriteLine(character.Health);

            // Calculator calc = new Calculator();
            // double square1 = calc.CalcByFormulaGerona(10, 20, 30);
            // double square2 = calc.CalcByHeightAndBase(20, 10);
            //

            // Calculator calculator = new Calculator();
            // double res = calculator.Average(new[] { 1, 2, 3, 4, 6, 5, 10 });
            //     
            // //Именнованные аргументы
            // double res2 = calculator.Average2(name: "Den", age: 31, 3, 4, 6, 5, 10);
            // Console.WriteLine(res);
            // Console.WriteLine(res2);

            // Calculator calculator = new Calculator();
            //
            // if (calculator.TryDevid(10, 2, out double result))
            // {
            //     Console.WriteLine(result);
            // }
            // else
            // {
            //     Console.WriteLine("Failed to divide");
            // }
            //
            //     Character c1 = new Character();
            //     Character c2 = new Character();
            //     
            //     Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. c2.Speed={c2.PrintSpeed()}");
            //
            //     c2.IncreaseSpeed();
            //     
            //   
            //     Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. c2.Speed={c2.PrintSpeed()}");
            // int a = 1;
            // int b = 2;
            //
            // Swap(ref a, ref b);
            // Console.WriteLine($"a={a}, b={b}");
            //
            // var list = new List<int>();
            // AddNumbers(list);
            //
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            //
            //
            // static void AddNumbers(List<int> numbers)
            // {
            //     numbers.Add(1);
            //     numbers.Add(2);
            //     numbers.Add(3);
            // }
            //
            // static void Swap(ref int a,ref int b)
            // {
            //     int tmp = a;
            //     a = b;
            //     b = tmp;
            // }

            // PointVal? pointVal = null;
            //
            // if (pointVal.HasValue)
            // {
            //    var num =  pointVal.Value.x;
            // }

            //Constructors();
            //*****************//


            // string id =  Inheritance();
            // Console.WriteLine(id);

            //*************************** Extention Interface *********************************//
            // List<object> list = new List<object>() {1,2,3,4};

            //ICollection collection = new BaseCollection(4);
            //collection.AddRange(list);

            //*************************** is a *********************************//
            /*
             IShape rect = new Rect {Height = 2, Width = 5};
             int rectResult = rect.CalcSquare();

             IShape square = new Square() {SideLength = 10};
             int squareResult = square.CalcSquare();

             Console.WriteLine($" Rect {rectResult}");
             Console.WriteLine($" Square {squareResult}");
            */

            //*************************** Enums *********************************//
            /*
            Character character = new Character(Race.Ork, 80, 200);
            Console.WriteLine(character.Race);
            */


            //*************************** Exception *********************************//
            // Character character = new Character("Licifer");
            //Console.WriteLine(character.Name);

            Complex c1 = new Complex(2, 5);
            Complex c2 = new Complex(1, 2);

            Complex result = c1.Plus(c2);
            Console.WriteLine($"{result.Real}: Real; {result.Imaginary}: Imaginary");
        }

        static void Boxing_Unboxing(object obj)
        {
            //первый способ кастования (разупоковака объекта)
            //проверяем, действительно ли объект являеться именно типа PointRef
            bool isPointerRef = obj is PointRef;

            if (isPointerRef)
            {
                //кастование, разупоковываем объект.
                PointRef pr = (PointRef)obj;
                Console.WriteLine(pr.x);
            }
            else
            {
                //do some think
            }

            //второй способ кастования (разупоковака объекта) используеться чаще подобный синтаксис
            PointRef pr1 = obj as PointRef;
            // Если obj  действительно являеться PointRef типа, автоматом преаброзует
            //в противном случае будет null
            if (pr1 != null)
            {
                Console.WriteLine(pr1.x);
            }
            else
            {
                //do some think  
            }
        }

        static void Constructors()
        {
            Character character = new Character(Race.Ork, 100);

            Console.WriteLine(character.Race);
        }

        static string Inheritance()
        {
            ModelXTerminal modelXTerminal = new ModelXTerminal("100");
            modelXTerminal.Connect();
            ModelYTerminal modelYTerminal = new ModelYTerminal("200");
            modelYTerminal.Connect();
            
            return modelYTerminal.id;
        }
    }
}