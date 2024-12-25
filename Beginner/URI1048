using System;
using System.Globalization;

class URI1038 {

    static void Main(string[] args) { 
        
        float salary = float.Parse(Console.ReadLine());

        float percentual = 0;

        if(salary <= 400.00){percentual = 0.15f;}
        if(salary > 400.00 && salary <= 800.00) {percentual = 0.12f;}
        if(salary > 800.00 && salary <= 1200.00) {percentual = 0.10f;}
        if(salary > 1200.00 && salary <= 2000.00) {percentual = 0.07f;}
        if(salary > 2000.00) {percentual = 0.04f;}

        float readjustvalue = percentual * salary;

        Console.WriteLine("Novo salario: " + (salary + readjustvalue).ToString("F2"));
        Console.WriteLine("Reajuste ganho: " + readjustvalue.ToString("F2"));
        Console.WriteLine("Em percentual: " + (percentual * 100)  + " %");

    }

}
