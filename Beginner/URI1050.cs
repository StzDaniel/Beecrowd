using System;

class URI1050
{
    static void Main(string[] args)
    {
        int ddd = int.Parse(Console.ReadLine());

        if (ddd != 61 && ddd != 71 && ddd != 11 && ddd != 21 && ddd != 32 && ddd != 19 && ddd != 27 && ddd != 31)
        {
            Console.WriteLine("DDD nao cadastrado");

        }
        else
        {
            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
            }
        }
    }
}

