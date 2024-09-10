// See https://aka.ms/new-console-template for more information

using PairCalculator;

class Program
{
    static void Main(string[] args)
    {
        IntCalculator cal = new();
        
        cal.Add(100000000);
        cal.Multiply(100000000);
        Console.WriteLine(cal.Result);
    }
}