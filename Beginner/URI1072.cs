using System;

class URI1072
{
    static void Main(string[] args)
    {
        int numbercount = int.Parse(Console.ReadLine());

        int ininterval = 0;
        int outinterval = 0;
        for (int i = 1; i <= numbercount; i++)
        {   
            int subject = int.Parse(Console.ReadLine());
            if (subject >= 10 && subject <= 20) { ininterval += 1; }
            else { outinterval += 1; }

        }
        Console.WriteLine(ininterval + " in");
        Console.WriteLine(outinterval + " out");
    }
}
