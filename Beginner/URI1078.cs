using System;

class URI1078
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++){
            Console.WriteLine(i + " x " + number + " = " + i * number);
        }
    }
}
