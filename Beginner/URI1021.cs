using System;

class Program
{
    static void Main(string[] args)
    {
        double value = Math.Round(double.Parse(Console.ReadLine()), 2);

        int[] notes = { 100, 50, 20, 10, 5, 2 };
        double[] coins = { 1.00, 0.50, 0.25, 0.10, 0.05, 0.01 };

        int intValue = (int)value;
        double fractionalValue = Math.Round(value - intValue, 2);

        Console.WriteLine("NOTAS:");
        foreach (int note in notes)
        {
            int noteCount = intValue / note;
            Console.WriteLine($"{noteCount} nota(s) de R$ {note:F2}");
            intValue %= note;
        }
      
        fractionalValue += intValue;

        Console.WriteLine("MOEDAS:");
        foreach (double coin in coins)
        {
            int coinCount = (int)(fractionalValue / coin);
            Console.WriteLine($"{coinCount} moeda(s) de R$ {coin:F2}");
            fractionalValue = Math.Round(fractionalValue % coin, 2);
        }
    }
}
