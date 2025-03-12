using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Définir la taille du tampon de la console
            int newBufferHeight = 50; // Par exemple, 50 lignes
            int newBufferWidth = Console.BufferWidth; // Utiliser la largeur actuelle du tampon

            Console.SetBufferSize(newBufferWidth, newBufferHeight);
            Accueil();
            Console.Read();
        }
        static void Accueil()
        {
            // Dessiner les 3 "cases" pour les options
            Console.WriteLine("╔══════════════╗  ╔══════════════╗ ");
            Console.WriteLine("║  1. Règles   ║  ║    2. Jeu    ║ ");
            Console.WriteLine("╚══════════════╝  ╚══════════════╝ ");
            Console.WriteLine();
            Console.Write("Entrez votre choix (1 ou 2) : ");

            string choix = Console.ReadLine();

            if (choix == "1")
            {
                Règles();
            }
            else if (choix == "2")
            {
                Games();
            }
            else
            {
                Console.WriteLine("1 ou 2, pas A ou 4....");
                Accueil(); // Retour au menu si l'option est invalide

            }

        }
        static void Games()
        {   // pour enlever l'accueil
            Console.Clear();

            //afficher le titre
            Title();

            // J'ai appris cette commande grâce à "https://dev.to/rasheedmozaffar/working-with-the-RandomValue-class-in-c-57i0"

            Random RandomValue = new Random();
            int NombreCase = RandomValue.Next(12, 17); // Génère un nombre entre 12 et 17 (17 exclu donc directement à 16)

            // mettre NombreCase pour avoir un tableau du même nombre et différent à chaque game

            int MargeTop = 4;

            Console.SetCursorPosition(4, 3);
            // code ASCII


            Console.Write("╔");

            int colonneActuelle = 1;
            while (colonneActuelle < NombreCase)
            {
                Console.Write("═══╦");
                colonneActuelle++;
            }

            Console.WriteLine("═══╗");
            Console.SetCursorPosition(4, MargeTop++);


            int ligneActuelle = 1;

            while (ligneActuelle < NombreCase)
            {

                Console.Write("║");


                colonneActuelle = 1;

                while (colonneActuelle < NombreCase)
                {
                    Console.Write("   ║");
                    colonneActuelle++;
                }
                Console.WriteLine("   ║");
                Console.SetCursorPosition(4, MargeTop++);

                Console.Write("╠");

                colonneActuelle = 1;

                while (colonneActuelle < NombreCase)
                {
                    Console.Write("═══╬");
                    colonneActuelle++;
                }
                Console.WriteLine("═══╣");
                Console.SetCursorPosition(4, MargeTop++);

                ligneActuelle++;
            }

            Console.Write("║");

            colonneActuelle = 1;

            while (colonneActuelle < NombreCase)
            {
                Console.Write("   ║");
                colonneActuelle++;
            }
            Console.WriteLine("   ║");
            Console.SetCursorPosition(4, MargeTop++);


            Console.Write("╚");

            colonneActuelle = 1;
            while (colonneActuelle < NombreCase)
            {
                Console.Write("═══╩");
                colonneActuelle++;
            }
            Console.Write("═══╝");




            /*
            Alt + 219 = █
            String Porte_Avions = ("███║███║███║███║███");
            String Croiseurs = ("███║███║███║███");
            String Contre_Torpilleurs = ("███║███║███");
            String Torpilleur = ("███║███");
            */

            DessinerBateau(6, 5, 2);
            DessinerBateau(9, 4, 3);
            DessinerBateau(8, 8, 4);
            DessinerBateau(2, 2, 5);


            Console.Clear();
            Title();

            // mettre NombreCase pour avoir un tableau du même nombre et différent à chaque game
            MargeTop = 4;

            Console.SetCursorPosition(4, 3);
            // code ASCII


            Console.Write("╔");
            colonneActuelle = 1;
            while (colonneActuelle < NombreCase)
            {
                Console.Write("═══╦");
                colonneActuelle++;
            }

            Console.WriteLine("═══╗");
            Console.SetCursorPosition(4, MargeTop++);


            ligneActuelle = 1;

            while (ligneActuelle < NombreCase)
            {

                Console.Write("║");


                colonneActuelle = 1;

                while (colonneActuelle < NombreCase)
                {
                    Console.Write("   ║");
                    colonneActuelle++;
                }
                Console.WriteLine("   ║");
                Console.SetCursorPosition(4, MargeTop++);

                Console.Write("╠");

                colonneActuelle = 1;

                while (colonneActuelle < NombreCase)
                {
                    Console.Write("═══╬");
                    colonneActuelle++;
                }
                Console.WriteLine("═══╣");
                Console.SetCursorPosition(4, MargeTop++);

                ligneActuelle++;
            }

            Console.Write("║");

            colonneActuelle = 1;

            while (colonneActuelle < NombreCase)
            {
                Console.Write("   ║");
                colonneActuelle++;
            }
            Console.WriteLine("   ║");
            Console.SetCursorPosition(4, MargeTop++);


            Console.Write("╚");

            colonneActuelle = 1;
            while (colonneActuelle < NombreCase)
            {
                Console.Write("═══╩");
                colonneActuelle++;
            }
            Console.Write("═══╝");

            /* 
             * int.Parse pour convertir en int les string, c'est pour les valeurs de l'utilisateur
             * Voici le lien pour comprendre mon problème depuis avant sur les valeurs de l'utilisateur : https://learn.microsoft.com/fr-fr/dotnet/api/system.int32.parse?view=net-8.0
             */


            for (int i = 1; i <= 30; i++)
            {

                Console.WriteLine();
                Console.Write("Choissisez une valeur pour l'horizontal : ");
                int UserValueHorizontal = int.Parse(Console.ReadLine());
                bool isOK = false;
                do
                {
                    if (UserValueHorizontal >= 1 && UserValueHorizontal <= NombreCase)
                    {
                        isOK = true;
                    }
                    else
                    {
                        Console.Write($"Entrez une valeur entre 12 et {NombreCase} : ");
                        UserValueHorizontal = int.Parse(Console.ReadLine());
                    }
                } while (!isOK);

                Console.Write("Choissisez une valeur pour le vertical : ");
                int UserValueVerticale = int.Parse(Console.ReadLine());
                isOK = false;
                do
                {
                    if (UserValueVerticale >= 1 && UserValueVerticale <= NombreCase)
                    {
                        isOK = true;
                    }
                    else
                    {
                        Console.Write($"Entrez une valeur entre 12 et {NombreCase} : ");
                        UserValueVerticale = int.Parse(Console.ReadLine());
                    }
                } while (!isOK);

                // toutes les positions des bateaux... c'était long
                bool ToucherBateau = (UserValueHorizontal == 6 && UserValueVerticale == 5) ||
                                     (UserValueHorizontal == 7 && UserValueVerticale == 5) ||
                                     (UserValueHorizontal == 9 && UserValueVerticale == 4) ||
                                     (UserValueHorizontal == 10 && UserValueVerticale == 4) ||
                                     (UserValueHorizontal == 11 && UserValueVerticale == 4) ||
                                     (UserValueHorizontal == 8 && UserValueVerticale == 8) ||
                                     (UserValueHorizontal == 9 && UserValueVerticale == 8) ||
                                     (UserValueHorizontal == 10 && UserValueVerticale == 8) ||
                                     (UserValueHorizontal == 11 && UserValueVerticale == 8) ||
                                     (UserValueHorizontal == 2 && UserValueVerticale == 2) ||
                                     (UserValueHorizontal == 3 && UserValueVerticale == 2) ||
                                     (UserValueHorizontal == 4 && UserValueVerticale == 2) ||
                                     (UserValueHorizontal == 5 && UserValueVerticale == 2) ||
                                     (UserValueHorizontal == 6 && UserValueVerticale == 2);


                int positionX = 2 + (UserValueHorizontal - 2) * 4; // Ajustement horizontal
                int positionY = 1 + (UserValueVerticale - 2) * 2; // Ajustement vertical

                if (ToucherBateau)
                {
                    Console.WriteLine("GG, c'est touché !");
                    Console.SetCursorPosition(positionX, positionY);
                    Console.ForegroundColor = ConsoleColor.Green;  // Couleur du pion
                    Console.Write("O");
                    Console.ResetColor(); // Réinitialiser la couleur pour les autres textes
                }
                else
                {
                    Console.WriteLine("Vous avez fail !");
                    Console.SetCursorPosition(positionX, positionY);
                    Console.ForegroundColor = ConsoleColor.Red;  // Couleur de la croix
                    Console.Write("X");
                    Console.ResetColor(); // Réinitialiser la couleur pour les autres textes
                }

                Console.WriteLine("Vous pouvez jouer encore" +(30-i)+ "coups");

            }
            Console.WriteLine("Vous avez fini de jouer !");

        }
        static void DessinerBateau(int x, int y, int longueur)
        {
            for (int Case = 0; Case < longueur; Case++)
            {
                Console.SetCursorPosition(1 + 4 * (x + Case), 2 + 2 * y);
                Console.WriteLine("███");
            }
        }

        static void Règles()
        {
            // pour effacer le bout de l'accueil
            Console.Clear();

            // ce texte vient de Wikipédia et je l'ai paragraphé
            Console.WriteLine("La bataille navale oppose deux joueurs.");
            Console.WriteLine("");
            Console.WriteLine("Chaque joueur dispose de deux grilles carrées de côté 10 à 16 (On choisit au départ) et une flotte composée de quelques bateaux.");
            Console.WriteLine("");
            Console.WriteLine("Au début du jeu, chaque joueur place ses bateaux sur sa grille, en s'assurant que deux bateaux ne sont pas adjacents.");
            Console.WriteLine("");
            Console.WriteLine("L'autre représente la zone adverse, où il cherchera à couler les bateaux de son adversaire.");
            Console.WriteLine("");
            Console.WriteLine("Chaque joueur, à son tour, annonce une case et son adversaire lui répond si le tir tombe à l'eau ou au contraire s'il touche un bateau.");
            Console.WriteLine("");
            Console.WriteLine(" Dans ce dernier cas, il annonce « touché » s'il reste des cases intactes au bateau ciblé, et « touché-coulé » si non");
            Console.WriteLine("");
            Console.WriteLine("Pour les Portes Avions c'est : ███ ███ ███ ███ ███");
            Console.WriteLine(" ");
            Console.WriteLine("Pour les Croiseurs c'est : ███ ███ ███ ███");
            Console.WriteLine(" ");
            Console.WriteLine("Pour les Contre Torpilleurs c'est : ███ ███ ███");
            Console.WriteLine(" ");
            Console.WriteLine("Pour les Torpilleurs c'est : ███ ███");
            Console.WriteLine("");
            Console.WriteLine("Tapez e pour quitter");
            string quitter = Console.ReadLine();


            if (quitter == "e")
            {
                Accueil();
            }
            else
            {
                Règles();
            }

        }

        static void Title()
        {

            Console.SetCursorPosition(3, 0);
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 1);
            Console.WriteLine("║Bienvenue dans la bataille navale d'Agashae Premakumar  ║");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");

        }

    }
}