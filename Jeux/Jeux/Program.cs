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

            Accueil();

            





            Console.Read();
        }
        static void Accueil()
        {
            // Dessiner les 3 "cases" pour les options
            Console.WriteLine("╔══════════════╗  ╔══════════════╗  ╔══════════════╗");
            Console.WriteLine("║  1. Règles   ║  ║    2. Jeu    ║  ║  3. Jeu LAN  ║");
            Console.WriteLine("╚══════════════╝  ╚══════════════╝  ╚══════════════╝");
            Console.WriteLine();
            Console.Write("Entrez votre choix (1, 2 ou 3) : ");

            string choix = Console.ReadLine();

            if (choix == "1")
            {
                Règles();
            }
            else if (choix == "2")
            {
                Games();
            }
            else if (choix == "3")
            {
                WithVichery();
            }
            else
            {
                Console.WriteLine("1, 2 ou 3, pas A ou 4....");
                Accueil(); // Retour au menu si l'option est invalide
     
            }

        }
        static void Games()
        {   // pour enlever l'accueil
            Console.Clear();

            //afficher le titre
            Title();

            // J'ai appris cette commande grâce à "https://dev.to/rasheedmozaffar/working-with-the-random-class-in-c-57i0"

            Random random = new Random();
            int x = random.Next(10, 17); // Génère un nombre entre 10 et 17 (17 exclu)


            // mettre x pour avoir un tableau du même nombre et différent à chaque game
            int Nombre_Ligne_Utilisateur = x;
            int Nombre_Colonne_Utilisateur = x;



            // code ASCII
            Console.Write("╔");

            int colonneActuelle = 1;

            while (colonneActuelle < Nombre_Colonne_Utilisateur)
            {
                Console.Write("═══╦");
                colonneActuelle++;
            }
            Console.WriteLine("═══╗");

            int ligneActuelle = 1;

            while (ligneActuelle < Nombre_Ligne_Utilisateur)
            {
                Console.Write("║");

                colonneActuelle = 1;

                while (colonneActuelle < Nombre_Colonne_Utilisateur)
                {
                    Console.Write("   ║");
                    colonneActuelle++;
                }
                Console.WriteLine("   ║");
                Console.Write("╠");

                colonneActuelle = 1;

                while (colonneActuelle < Nombre_Colonne_Utilisateur)
                {
                    Console.Write("═══╬");
                    colonneActuelle++;
                }
                Console.WriteLine("═══╣");

                ligneActuelle++;
            }

            Console.Write("║");

            colonneActuelle = 1;

            while (colonneActuelle < Nombre_Colonne_Utilisateur)
            {
                Console.Write("   ║");
                colonneActuelle++;
            }
            Console.WriteLine("   ║");

            Console.Write("╚");

            colonneActuelle = 1;

            while (colonneActuelle < Nombre_Colonne_Utilisateur)
            {
                Console.Write("═══╩");
                colonneActuelle++;
            }
            Console.Write("═══╝");
























            /*
            Alt + 219 = █
            Cuirassé : 1 bateau de 5 cases
            Croiseur : 1 bateau de 4 cases
            Destroyers : 2 bateaux de 3 cases
            Sous-marins : 2 bateaux de 2 cases
            */

            Console.SetCursorPosition(12, 7);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorSize = 100;
            
            String Porte_Avions = ("███ ███ ███ ███ ███");
            String Croiseurs = ("███ ███ ███ ███");
            String Contre_Torpilleurs = ("███ ███ ███");
            String Torpilleur = ("███ ███");
            
            Console.WriteLine(Porte_Avions);

            
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
            int TitlePosLeft = 4;
            int TitlePosTop = 2;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Bienvenue dans la bataille navale d'Agashae Premakumar  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");

        }

        static void WithVichery()
        {
            Console.WriteLine("Hello");
        }

    }
}




        



