using System;

class URI1095
{
    static void Main(string[] args)
    {
       int Jnum = 60;
       int Inum = 1;
       
       while(Jnum >= 0){
        Console.WriteLine("I=" + Inum + " J=" + Jnum);
        Inum += 3;
        Jnum -= 5;
       }
    }
}
