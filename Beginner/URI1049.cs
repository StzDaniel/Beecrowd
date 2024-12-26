using System;

class URI1038
{
    static void Main(string[] args)
    {
        string tipo = Console.ReadLine();
        string classe = Console.ReadLine();
        string alimentacao = Console.ReadLine();

        string subject = "";

        switch (tipo)
        {
            case "vertebrado":
                switch (classe)
                {
                    case "ave":
                        switch (alimentacao)
                        {
                            case "carnivoro":
                                subject = "aguia";
                                break;
                            case "onivoro":
                                subject = "pomba";
                                break;
                        }
                        break;
                    case "mamifero":
                        switch (alimentacao)
                        {
                            case "onivoro":
                                subject = "homem";
                                break;
                            case "herbivoro":
                                subject = "vaca";
                                break;
                        }
                        break;
                }
                break;
            case "invertebrado":
                switch (classe)
                {
                    case "inseto":
                        switch (alimentacao)
                        {
                            case "hematofago":
                                subject = "pulga";
                                break;
                            case "herbivoro":
                                subject = "lagarta";
                                break;
                        }
                        break;
                    case "anelideo":
                        switch (alimentacao)
                        {
                            case "hematofago":
                                subject = "sanguessuga";
                                break;
                            case "onivoro":
                                subject = "minhoca";
                                break;
                        }
                        break;
                }
                break;
        }

        Console.WriteLine(subject);
    }
}
