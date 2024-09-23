namespace Distributeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock1 = 5; //Valeur fictive pour test
            int stock2 = 2; //Valeur fictive pour test
            int stock3 = 0; //Valeur fictive pour test

            Console.WriteLine("Veuillez sélectionner une boisson :");
            Console.WriteLine("1. Eau");
            Console.WriteLine("2. Soda");
            Console.WriteLine("3. Orangeade");

            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    if (stock1 != 0)
                    {
                        Console.WriteLine("Voici votre eau");
                        stock1 = stock1 - 1;
                    }
                    else
                        Console.WriteLine("Sold out!");
                    break;
                case "2":
                    if (stock2 != 0)
                    {
                        Console.WriteLine("Voici votre soda");
                        stock2 = stock2 - 1;
                    }
                    else
                        Console.WriteLine("Sold out!");
                    break;
                case "3":
                    if (stock3 != 0)
                    {
                        Console.WriteLine("Voici votre orangeade");
                        stock3 = stock3 - 1;
                    }
                    else
                        Console.WriteLine("Sold out!");
                    break;
                default:
                    Console.WriteLine("Choix indisponible");
                    break;
            }
        }
    }
}
