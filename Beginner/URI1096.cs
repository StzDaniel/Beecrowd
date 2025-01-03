using System;

class URI1096
{
    static void Main(string[] args)
    {
        int Inum = 1;
        int Jnum = 7;

        while (Inum <= 9)
        {
            for (int i = 0; i != 3; i++)
            {
                Console.WriteLine("I=" + Inum + " J=" + Jnum);
                Jnum -= 1;
            }
            Inum += 2;
            Jnum = 7;

        }
    }
}
