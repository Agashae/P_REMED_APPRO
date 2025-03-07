# Suivi des activités

## 31.1

- Feedback XCL
    - Je suis presque sûr de vous avoir vu avec un contrat quasi finalisé, mais je ne le trouve pas dans votre repo
    - Finalisez-le en pdf signé, enregistré dans le repo, et commencez le travail

- JDT
    - 17.1.25
        - 15h00-15h30 -> me documenter sur le jeu et débuter le CDC avec les étapes pour créer ce jeu
        - 15h30-15h45 -> créer le titre et les variables pour les cases
        - 15h45-16h10 -> demander à Vichery pour savoir si on fait une version local avec 2 joueurs ou 1 joueur par PC et voir la difficulté de chaque code
        - 16h10-16h40 -> faire la grille pour la bataille navale à l'aide du puissance 4 du I319
    
    - 18.1.25
        - 18h30-19h30 -> Faire la demande des valeurs à l'utilisateur et copier et expliquer le quadrillage du C# avec le I319 du puissance4
        - 21h30-22h00 -> Débuter la conception des bateaux, voir si je fais une forme par bateau et la mettre en variable, ou bien faire avec █ et dessiner avec
    
    - 19.1.25
        - 12h30-13h00 -> Préparer les static void pour le jeu, les régles, l'accueil, le jeu avec Vichery et le titre
        - 13h00-13h30 -> Faire une belle interface pour l'accueil avec des Console.WriteLine(""); et faire une condition pour choisir l'option qu'on veut avec des if / else if
    
    - 24.1.25
        - 10h00-10h30 -> Corriger le static void() Règles
        - 10h30-11h00 -> Régler le fait qu'on ne peut pas quitter les régles avec la touche ("Q")
    
    - 25.1.25
        - 21h30-22h15 -> Faire en sorte d'avoir un tableau différent à chaque partie
    
    - 31.1.25
        - 14h00-14h40 -> On a eu des consignes sur GitHub + sur l'installation de MarkDown
        - 14h45-14h45 -> Imprimer, signer et numériser le contrat de remédiation
        - 15h00-15h40 -> Comprendre MarkDown, corriger le feedback XCL et mettre le JDT dans le MarkDown
        - 15h40-16h25 -> Changer la position du tableau dans C# + des bateaux pour tous les voir et pas mettre trop de bateaux, car il y'a plusieurs types de bateaux 
        - 16h25-16h40 -> Le professeur m'a dit de simplifier le tableau
     
## 7.2

- Feedback XCL
    - Le journal de travail est impeccable, bravo. Continuez-le de la même manière ci-dessous.
    - Je vous donnerai un retour sur le code prochainement
 
- JDT
        - 14h00-14h30 Recevoir quelques consignes concernant la méthode Pomodoro  
        - 14h30-15h00 Changer la position du tableau  
        - 15h00-16h40 Mettre tout les bateaux rouge sur le tableau et voir pour définir une position random dans le tableau pour chacun en fonction de la taille du tableau et éviter la superpostion des bateaux dans le tableau tout en prenant en compte, qu'il puisse avoir une version avec des bateaux jaunes pour l'adversaire

## 14.2
- Feedback XCL
    - Journal: faites attention à mettre deux espaces à la fin des lignes pour que le rendu soit correct
    - Journal: A l'avenir, ne mettez pas toutes les tâches ensemble avec des '... et ...' entre deux. Chacun de ces éléments doit être une entrée du journal.
    - Dans votre repo, on ne devrait pas trouver les dossier `bin/Debug` et `obj/Debug`. Renseignez-vous sur le [.gitignore](https://talks.freelancerepublik.com/fichier-gitignore-git-comment-lutiliser/). Demandez-moi des explications si besoin.
    - Continuez votre développement
 
- JDT
    - 14.2.25
        - 14h00-14h15 Recevoir quelques consignes du professeur
        - 14h15-14h30 Trouver le moyen de d'ajouter les ║ entre les cases et de la bonne couleur
        - 14h30-16h00 Enlever la partie random des positions des bateaux et écrire manuellement
        - 16h00-16h40 Problème avec mon GitHub, donc le professeur m'a aidé

## 28.2
- Feedback XCL
    - Veillez à TOUJOURS travailler dans le repo local et faire des commits/push régulier. Ajouter des fichiers par téléchargement sur Github.com devrait être EXTREMEMENT RARE.
    - Nommez mieux vos variables: `x` ne me permet pas de comprendre à quoi elle sert. `tailleGrille` serait beaucoup mieux
    - Au lieu de dessiner des bateaux fixes, faites une méthode qui dessine un bateau d'une longueur voulue, genre:
    ```csharp
    static void DessinerBateau (int x, int y, int longueur)
    {
        for (int i=0; i<longueur; i++)
        {
            Console.SetCursorPosition(5 + 4*i, y);
            Console.WriteLine("███");
        }
    }
    ```
    - Donnez tout de suite de bons noms à vos méthodes: `EnReseau()` par exemple, plutôt que `WithVichery`

- JDT
    - 28.2.25
        - 14h00-14h15 Apprendre à bien nommer les commits
        - 14h15-14h45 Changer les noms de variables
        - 15h00-16h40 Changer les méthodes pour le positionnement des bateaux


## 7.3

- Feedback XCL
    - J'avais demandé de faire un bilan des objectifs, il n'a pas été fait
    - Nommage de commit: vous n'avez pas bien compris un point de la doc, celui qui dit "Le nom de votre commit est ce que vous mettriez à la place des points de suspension". Du coup, si "ce commit permet de changer la méthode de positionnement des bateaux", le nom à donner à votre commit c'est "fix (programme): changer la méthode de positionnement des bateaux"
    - Journal : ok, vous pouvez donner un tout petit peu plus de détails: qu'avez-vous changé ? pourquoi ?

- Journal de travail
    - 7.3.25
        - 14h00-14h45 Aide du professeur sur l'algorithme des bateaux
        - 14h45-15h30 Création des différents bateaux 
        - 15h30-15h40 Abandon du mode en ligne car je n'ai pas le temps, modification du code pour l'enlever
        - 15h40-16h40 Création du tableau d'historique + Clean mon code en ajoutant + de méthode
        - 19h45-20h45 Problème depuis chez moi avec System.ArgumentOutOfRangeException 
        - 21h00-21h30 Valeur X et Y choisit par l'utilisateur 