

/*Using the following table, write a program that reads a code and the amount of an item. After, print the value to pay. This is a very simple program with the only intention of practice of selection commands.

The input file contains two integer numbers X and Y. X is the product code and Y is the quantity of this item according to the above table.*/


using System;
using System.Globalization;

class URI1038 {

    static void Main(string[] args) { 

        string[] pedido = Console.ReadLine().Split(' ');
        float[] precos = [4f, 4.5f, 5.00f, 2.00f, 1.50f];

        Console.WriteLine("Total: R$ " + ((precos[int.Parse(pedido[0]) - 1])  *  int.Parse(pedido[1])).ToString("F2"));
    }

}
