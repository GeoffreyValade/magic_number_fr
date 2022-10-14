using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int DemanderNombre(int MIN, int MAX)
        {
            int nombreUtilisateur = 0;

            while ((nombreUtilisateur < MIN) || (nombreUtilisateur > MAX))
            {
                Console.Write("Veuillez rentrer un nombre entre " + MIN + " et " + MAX + " : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if ((nombreUtilisateur < MIN) || (nombreUtilisateur > MAX))
                    {
                        Console.WriteLine("Erreur : le nombre doit être entre " + MIN + " et " + MAX + ".");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur : veuillez rentrer des chiffres.");
                }
            }
            return nombreUtilisateur;
        }


        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 10;
            Random rand = new Random();
            int magique = rand.Next(MIN, MAX+1);

            int nombre = MIN - 1;

            int nbVies = 4;

            while (nbVies > 0)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                nombre = DemanderNombre(MIN, MAX);
                Console.WriteLine();
                if (magique < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else if (magique > nombre)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
                else
                {
                    break;
                }
                nbVies--;
            }

            if (nombre == magique)
            {
                Console.WriteLine("Bravo ! Vous avez trouvé le nombre magique.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Vous avez perdu. Le nombre magique était : " + magique);
            }
            
        }

    }

    
}