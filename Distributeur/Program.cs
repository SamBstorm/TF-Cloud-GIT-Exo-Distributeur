namespace Distributeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stocks = new int[3];
            stocks[0] = 3; //Valeur fictive pour test
            stocks[1] = 0; //Valeur fictive pour test
            stocks[2] = 2; //Valeur fictive pour test
            string[] noms = new string[3];
            noms[0] = "Eau";
            noms[1] = "Soda";
            noms[2] = "Orangeade";
            int totalStock = stocks.Count();
            int choix = 0;
            while (totalStock > 0 && choix != 4)
            {
                do
                {
                    Console.WriteLine("Veuillez sélectionner une boisson :");
                    for (int i = 0; i < noms.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {noms[i]}");
                    }
                    Console.WriteLine("4. Finir");
                } while (!int.TryParse(Console.ReadLine(), out choix) || choix < 1 || choix > 4);
                if (choix != 4)
                {
                    if (stocks[choix - 1] > 0)
                    {
                        Console.WriteLine($"Voici votre {noms[choix - 1]}");
                        stocks[choix - 1]--;
                    }
                    else
                        Console.WriteLine($"Plus de {noms[choix - 1]}");
                }
                totalStock = stocks.Count();
            }
            Console.WriteLine("Merci d'utiliser distributeur 3000!");
        }
    }
}
