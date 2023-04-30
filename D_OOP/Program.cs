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
  
            Character c1 = new Character();
            Character c2 = new Character();

            Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. c2.Speed={c2.PrintSpeed()}");

            c2.IncreaseSpeed();
          
            Console.WriteLine($"c1.Speed={c1.PrintSpeed()}. c2.Speed={c2.PrintSpeed()}");
        }
    }
}