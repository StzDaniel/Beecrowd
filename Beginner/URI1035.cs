/*Read 4 integer values A, B, C and D. Then if B is greater than C and D is greater than A and if the sum of C and D is greater than the sum of A and B and if C and D were positives values and if A is even, write the message “Valores aceitos” (Accepted values). Otherwise, write the message “Valores nao aceitos” (Values not accepted). */

using System;

class uri1035
{
    static void Main(string[] args)
    {

        string[] Vector = Console.ReadLine().Split(' ');

        int A, B, C, D;

        A = int.Parse(Vector[0]);
        B = int.Parse(Vector[1]);
        C = int.Parse(Vector[2]);
        D = int.Parse(Vector[3]);

        if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }


    }
}
