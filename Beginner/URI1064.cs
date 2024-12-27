using System;
using System.Globalization;
using System.Collections.Generic;

class URI1050
{
    static void Main(string[] args)
    {   
        List<float> numbers = new List<float>();
        
        for(int i = 0; i < 6; i++)
        {
            numbers.Add(float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
        }
        
        int positives = 0;
        float soma = 0;

        foreach(float num in numbers)
        {
            if(num > 0)
            {
                soma += num;
                positives += 1;
            }
        }

        if (positives > 0)
        {
            Console.WriteLine(positives + " valores positivos");
            Console.WriteLine((soma / positives).ToString("F2"));
        }
        else
        {
            Console.WriteLine("0 valores positivos");
            Console.WriteLine("0.0");
        }
    }
}
