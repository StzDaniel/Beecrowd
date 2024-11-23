/*Read 3 floating-point numbers. After, print the roots of bhaskara’s formula. If it's impossible to calculate the roots because a division by zero or a square root of a negative number, presents the message “Impossivel calcular”.*/

URI using System;

class uri1036
{
    static void Main(string[] args)
    {

        string[] Vector = Console.ReadLine().Split(" ");

        double A, B, C;

        A = double.Parse(Vector[0]);
        B = double.Parse(Vector[1]);
        C = double.Parse(Vector[2]);

        double Delta = Math.Pow(B, 2) - 4.0 * A * C;

        if (A == 0 || Delta < 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            double X1 = (-B + Math.Sqrt(Delta)) / (2.0 * A);
            double X2 = (-B - Math.Sqrt(Delta)) / (2.0 * A);

            Console.WriteLine("R1 = " + X1.ToString("F5"));
            Console.WriteLine("R2 = " + X2.ToString("F5"));
        }

    }
}
1036
