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
            
            /*
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

            Console.Write("Choissisez une valeur pour l'horizontal : ");
            int UserValueX = Console.Read();
            bool isOK = false;

            do
            {
                if (UserValueX >= 12 && UserValueX <= NombreCase)
                {
                    isOK = true;
                }
            } while (isOK == false);

            Console.Write("Choissisez une valeur pour le vertical : ");
            int UserValueY = Console.Read();
            isOK = false;

            do
            {
                if (UserValueX >= 12 && UserValueX <= NombreCase)
                {
                    isOK = true;
                }
            } while (isOK == false);

            int[,] Tableau = new int[UserValueX, UserValueY];


            Console.Write(UserValueX);
        Console.Write(UserValueY);

            Console.Read();
            */

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