namespace D_OOP;

public static class Calculator
{
    private static Dictionary<char, int> map = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    //сигнатура
    public static double CalcByFormulaGerona(double ab, double bc, double ac)
    {
        double p = (ab + bc + ac) / 2;

        return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
    }

    public static double CalcByHeightAndBase(double b, double h)
    {
        return 0.5 * b * h;
    }

    public static double Average(int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        //изменения типа переменной sum
        return (double)sum / numbers.Length;
    }

    //Params in method (синтакс. сахар) *** 
    public static double Average2(string name, int age, params int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }

    public static bool TryDevid(double divisible, double divisor, out double result)
    {
        //необходимо заполнять переменную out дефолтным состоянием.
        result = 0;
        if (divisor == 0)
        {
            return false;
        }
        else
        {
            result = divisible / divisor;
            return true;
        }
    }
}