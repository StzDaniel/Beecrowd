/*Problema:
    Ler um valor inteiro correspondente à idade de uma pessoa em dias e mostrar a idade em anos, meses e dias (considerando que o ano tem 365 dias todos de 30 dias)*/
//C#:

using System;

class URI1020
{
    static void Main(string[] args)
    {

        int daysin = int.Parse(Console.ReadLine());

        int years = daysin / 365;
        int months = daysin % 365 / 30;
        int daysout = daysin % 365 % 30 / 1;
    
        Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)", years, months, daysout);
    }
}
