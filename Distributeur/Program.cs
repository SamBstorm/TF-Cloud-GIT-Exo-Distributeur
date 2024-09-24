namespace Distributeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock1 = 5; //Valeur fictive pour test
            int stock2 = 2; //Valeur fictive pour test
            int stock3 = 0; //Valeur fictive pour test
            string choix;
            do
            {

                Console.WriteLine("Veuillez sélectionner une boisson :");
                Console.WriteLine("1. Eau");
                Console.WriteLine("2. Soda");
                Console.WriteLine("3. Orangeade");
                Console.WriteLine("4. Finir");

                choix = Console.ReadLine();

                if (choix == "1")
                {
                    if (stock1 != 0)
                    {
                        Console.WriteLine("Voici votre eau");
                        stock1 = stock1 - 1;
                    }
                    else
                        Console.WriteLine("Sold out!");

                }
                else if (choix == "2")
                {
                    if (stock2 != 0)
                    {
                        Console.WriteLine("Voici votre soda");
                        stock2 = stock2 - 1;
                    }
                    else
                        Console.WriteLine("Sold out!");
                }
                else if (choix == "3")
                {
                    if (stock3 != 0)
                    {
                        Console.WriteLine("Voici votre orangeade");
                        stock3 = stock3 - 1;
                    }
                    else
                        Console.WriteLine("Sold out!");
                }
            } while ((stock1 + stock2 + stock3 > 0) && choix != "4");
            Console.WriteLine("Merci d'utiliser distributeur 3000!");
        }
    }
}
