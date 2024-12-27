using System;

class URI1067
{
    static void Main(string[] args)
    {   
        int number = int.Parse(Console.ReadLine());

        for(int i = 1; i <= number; i++){
            if(i % 2 != 0){Console.WriteLine(i);}
        }
    }
}
