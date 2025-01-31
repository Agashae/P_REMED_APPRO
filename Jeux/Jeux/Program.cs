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

            // mettre 0 c'est pour les définir et pour que le user puisse lui même écrasé ça pour le modifier
            int Nombre_Ligne_Utilisateur = 0;
            int Nombre_Colonne_Utilisateur = 0;

            int Nombre_Ligne_Minimum = 16;
            int Nombre_Ligne_Maximum = 10;
            int Nombre_Colonne_Maximum = 16;
            int Nombre_Colonne_Minimum = 10;
            do
            {
                //faire une boucle pour voir si les nombres sont en normes
                Console.Write("Prenez une valeur entre 10 et 16 : ");

                try
                {       // converti la réponse en Int32
                    Nombre_Ligne_Utilisateur = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Mais non ! 10 à 16 ! ");
                }


                // user_value_horizontal + petit que ND_ROW_Min et en même temps user_value_horizontal est + grand que ND_ROW_Max
                if (Nombre_Ligne_Utilisateur < Nombre_Ligne_Maximum || Nombre_Ligne_Utilisateur > Nombre_Ligne_Minimum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Il faut mettre un nombre valide !!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (Nombre_Ligne_Utilisateur < Nombre_Ligne_Maximum || Nombre_Ligne_Utilisateur > Nombre_Ligne_Minimum);


            do
            {
                Console.Write("Prenez une valeur entre 10 et 16 : ");

                try
                {
                    // Code susceptible de générer une exception
                    Nombre_Colonne_Utilisateur = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                // Code qui s'exécute si une exception est capturée et e est le nom de la variable
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Il y a une erreur.... une GROSSE !");
                    Console.ForegroundColor = ConsoleColor.White;

                }



                if (Nombre_Colonne_Utilisateur < Nombre_Colonne_Minimum || Nombre_Colonne_Utilisateur > Nombre_Colonne_Maximum)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Sérieusement !!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            } while (Nombre_Colonne_Utilisateur < Nombre_Colonne_Minimum || Nombre_Colonne_Utilisateur > Nombre_Colonne_Maximum);

            // Cette partie est prise du code Puissance 4 I319 

            // nettoie la page
            Console.Clear();
            // montre le titre encore, c'est une sorte de variable
            Title();


            // Validation des dimensions utilisateur
            if (Nombre_Ligne_Utilisateur < Nombre_Ligne_Minimum || Nombre_Ligne_Utilisateur > Nombre_Ligne_Maximum)
            {
                Nombre_Ligne_Utilisateur = Nombre_Ligne_Minimum;
            }

            if (Nombre_Colonne_Utilisateur < Nombre_Colonne_Minimum || Nombre_Colonne_Utilisateur > Nombre_Colonne_Maximum)
            {
                Nombre_Colonne_Utilisateur = Nombre_Colonne_Minimum;
            }

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




        



