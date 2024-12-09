//Achei paia essa

using System;
using System.Globalization;

class URI1037 {

    static void Main(string[] args) { 

        float number = float.Parse(Console.ReadLine());

        if (number < 0 | number > 100){Console.WriteLine("Fora de intervalo");}
        if (number >= 0 && number <= 25){Console.WriteLine("Intervalo [0,25]");}
        if (number > 25 && number <= 50){Console.WriteLine("Intervalo (25,50]");}
        if (number > 50 && number <= 75){Console.WriteLine("Intervalo (50,75]");}
        if (number > 75 && number <= 100){Console.WriteLine("Intervalo (75,100]");}

    }

}
