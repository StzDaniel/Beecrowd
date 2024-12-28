using System;

class URI1078
{
    static void Main(string[] args)
    {
        int expcount = int.Parse(Console.ReadLine());

        int coelhos = 0;
        int ratos = 0;
        int sapos = 0;

        for (int i = 1; i <= expcount; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            int quantia = int.Parse(data[0]);
            char tipo = data[1][0];

            if (tipo == 'C') { coelhos += quantia; }
            else if (tipo == 'R') { ratos += quantia; }
            else if (tipo == 'S') { sapos += quantia; }
        }

        int total = coelhos + ratos + sapos;
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);
        
        Console.WriteLine("Percentual de coelhos: " + (coelhos / (double)total * 100.0).ToString("F2") + " %");
        Console.WriteLine("Percentual de ratos: " + (ratos / (double)total * 100.0).ToString("F2") + " %");
        Console.WriteLine("Percentual de sapos: " + (sapos / (double)total * 100.0).ToString("F2") + " %");
    }
}
