using System;

class URI1051
{
    static void Main()
    {
        double salario = double.Parse(Console.ReadLine());
        double imposto = 0.0;

        if (salario <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else
        {
            if (salario <= 3000.00)
            {
                imposto += (salario - 2000.00) * 0.08;
            }
            else
            {
                imposto += 1000.00 * 0.08;
                if (salario <= 4500.00)
                {
                    imposto += (salario - 3000.00) * 0.18;
                }
                else
                {
                    imposto += 1500.00 * 0.18;
                    imposto += (salario - 4500.00) * 0.28;
                }
            }
            Console.WriteLine($"R$ {imposto:F2}");
        }
    }
}
