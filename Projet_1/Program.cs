using System;
namespace Projet_1
{
    class Program
    {

        // Zone d'exécution du logiciel

        static int numEntree;
        static void Main(string[] args)
        {
            Box box = new Box();
           
            bool isActiveLogiciel = true;
            while (isActiveLogiciel)
            {
                Console.WriteLine("********************************************************************");
                Console.WriteLine("******LOGICIEL DE GESSION DE LA LISTE DES ANIMAUX EN PENSIONS*******");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("Faire un choix parmis les huit options suivantes:");
                Console.WriteLine("1- Ajouter un animal");
                Console.WriteLine(" \t ID, type d'animal, son nom, son âge, son poids, la couleur (rouge, bleu et violet uniquement)");
                Console.WriteLine("\t le nom du propriétaire");
                Console.WriteLine("2- Voir la liste de tous les animaux en pension");
                Console.WriteLine("3- Voir la liste de tous les propriétaires");
                Console.WriteLine("4- Voir le nombre total d'animaux en pension");
                Console.WriteLine("5- Voir le poids total de tous les animaux en pension");
                Console.WriteLine("6- Voir la liste des animaux d'une couleur (rouge, bleu ou violet)");
                Console.WriteLine("7- Retirer un animal de la liste");
                Console.WriteLine("8- Quitter");
                Console.WriteLine("Votre option?");
                string entree = Console.ReadLine();
                int entier;
                bool isNumeric = int.TryParse(entree, out entier);
                if(!isNumeric)
                {
                    Console.WriteLine("L'option n'est pas valide...");
                    Console.WriteLine("Veiller choisir un chiffre parmi les huits options ci-dessus");
                }
                else
                {
                    numEntree = int.Parse(entree);
                    switch (numEntree)
                        {
                            case 1:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 2:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 3:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 4:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 5:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 6:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 7:
                            box.MenuVeterinaire(numEntree);
                            break;
                            case 8:
                            box.MenuVeterinaire(numEntree);
                            break;
                            default:
                            Console.WriteLine("Le choix n'est pas valide...");
                            break;
                    }
                
                } 

            }
        }
    }
    // Zone de traitement des différentes tâches (Mes fonctions)
    class Box
    {



        // Décaration de mes variables globales
        static int nombreAnimal = 0;       // pour compter le nombre d'animaux
        static int ID = 0;
        static int poidsTotAnimaux = 0;    // pour faire le total des poids des animaux à chaque ajout

        static string[,] listeAnimal = new string[10, 7]; // La liste pouvant contenir 10 animaux avec 7 caractéristiques


        // Menu 1: Fonction qui ajoute un animal à la liste d'animaux
        public void AjouterAnimal()
        {

            if(nombreAnimal < 10) // test si le tableau n'est pas plein avant d'ajouter un animal 
            {
                // Récupérer le nom de l'animal
                Console.WriteLine("Veiller saisir le type de l'animal");
                string typAnimal = Console.ReadLine();
                // Récupérer le nom du propriétaire de l'animal
                Console.WriteLine("Veiller saisir le nom de l'animal");
                string nomAnimal = Console.ReadLine();
                // Récupérer l'age de l'animal en entier uniquement
                bool isNumeric;
                int nbrEntier;
                string ageAnimal;
                do
                {
                    Console.WriteLine("Veiller saisir l'age de l'animal (En nombre entier)");
                    ageAnimal = Console.ReadLine();
                    isNumeric = int.TryParse(ageAnimal, out nbrEntier);
                }while(!isNumeric);
                // Récupérer le nom le poids de l'animal en entier uniquement
                string poidsAnimal;
                do
                {
                    Console.WriteLine("Veiller saisir le poids de l'animal (En nombre entier)");
                    poidsAnimal = Console.ReadLine();
                    isNumeric = int.TryParse(poidsAnimal, out nbrEntier);
                } while (!isNumeric);
                // Récupérer le nom la couleur de l'animal en rouge, bleu et violet uniquement
                string couleurAnimal;
                do
                {
                    Console.WriteLine("Veiller saisir la couleur de l'animal (rouge ou bleu ou violet)");
                    couleurAnimal = Console.ReadLine();

                } while ((couleurAnimal != "rouge") && (couleurAnimal != "bleu") && (couleurAnimal != "violet"));
                // Récupérer le nom du propriétaire de l'animal
                Console.WriteLine("Veiller saisir le nom du propriétaire de l'animal");
                string propiAnimal = Console.ReadLine();
                // Tableau des infos (caractéristiques de l'animal) remplies en entrée et son indentifiant (ID) allant de 0 à 9
                string[] nouveauAnimal = new string[] { Convert.ToString(ID), typAnimal, nomAnimal, ageAnimal, poidsAnimal, couleurAnimal, propiAnimal };
                // Ajout l'animale à la ligne nombreAnimal (première fois nombreAnimal=0)
                for (int i = 0; i < 7; i++)
                {

                    listeAnimal[nombreAnimal, i] = nouveauAnimal[i];
                }
                // Après l'ajout de l'animale faire :
                poidsTotAnimaux = poidsTotAnimaux + int.Parse(poidsAnimal); // incrémente le poids total d'animaux
                nombreAnimal = nombreAnimal + 1;                            // incrémente le nombre d'animaux
                ID = ID + 1;

            }
            // Si la liste des animaux est 10 alors dire que la liste est pleine
            else
            {
                Console.WriteLine("Le nombre total d'adimaux admise est 10");
            }
           

        }

        // Menu 2: Fonction qui affiche la liste des animaux
        public void AfficherTousAnimaux()
        {
 
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

            for (int i = 0; i < nombreAnimal; i++)    // parcourir les lignes du tableau
            {
                for (int j = 0; j < 7; j++)            // parcourir les colonnes du tableau
                {
                    Console.Write(listeAnimal[i, j] + "       \t");    // remplir le tableau 
                }
                Console.WriteLine();
            }
           

        }

        // Menu 3: Fonction qui affiche la liste des propriétaires des animaux
        public void AfficherProprietaires()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" |   PROPRIÉTAIRE |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");

         // Affiche la colonne 6 contenant les propriétaires
                for (int i = 0; i < nombreAnimal; i++)
                {
                    Console.Write( listeAnimal[i, 6] + "  \n ");
                }
           
        }

        // Menu 4: Fonction qui affiche le nombre total des animaux  
        public void AfficherTotalAnimaux()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" |   NOMBRE ANIMAUX |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine( nombreAnimal);
          
        }

        // Menu 5: Fonction qui affiche le poids total des animaux
        public void AfficherPoidsTotalAnimaux()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(" |   POIDS TOTAL |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine(poidsTotAnimaux);
           
        }

        // Menu 6: Fonction qui affiche la liste des animaux selon la couleur 
        public void AfficherAnimauxParCouleur()
        {
            string couleurAnimal;
            // demande une couleur entre rouge, bleu ou violet
            do
            {
                Console.WriteLine("Veiller saisir la couleur des animaux à afficher (rouge ou bleu ou violet)");
                couleurAnimal = Console.ReadLine();

            } while ((couleurAnimal != "rouge") && (couleurAnimal != "bleu") && (couleurAnimal != "violet"));

            Console.WriteLine("--------------------------------------------------------------------------------------------");
            Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   COULEUR   |");
            Console.WriteLine("--------------------------------------------------------------------------------------------");
            // affiche les animaux dont la couleur est récuperer dans la variable couleurAnimal
            for (int i = 0; i < nombreAnimal; i++)
            {
               
                    if (listeAnimal[i, 5] == couleurAnimal)   // test si c'est la couleur qu'on veut afficher
                    {
                        Console.Write( listeAnimal[i, 0] + "\t");
                        Console.Write(listeAnimal[i, 1] + "\t");
                        Console.Write(listeAnimal[i, 2] + "\t");
                        Console.Write(listeAnimal[i, 5] + "\t");
                    }
                    
             
                Console.WriteLine();
            }
          
        }

        // Menu 7: Fonction qui retire un animal du tableau d'animaux
        public void RetirerAnimal()
        {
            if ((nombreAnimal == 0))         // test si le tableau 0 animal
            {
                // afficher liste vide
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("Liste vide");
               
            }
            // si le tableau contient au moins 1 animal alors faire :
            else
            {
                string ID_suprime;
                do
                {
                    Console.WriteLine("Veiller saisir le numéro (ID) de l'animal à suprimer de la liste )");
                    ID_suprime = Console.ReadLine();

                } while (int.Parse(ID_suprime) >= nombreAnimal);

                int IDsuprime = int.Parse(ID_suprime);
                bool isIndice = false;
                for(int k = 0; k < nombreAnimal; k++)
                {
                  if(IDsuprime == int.Parse(listeAnimal[k,0]))
                    {
                        isIndice = true;
                    }
                }
                if(isIndice)
                {
                    // avant suppression diminuer le poids total des animaux
                    poidsTotAnimaux = poidsTotAnimaux - int.Parse(listeAnimal[IDsuprime, 4]);
                    // suppression

                    for (int j = 0; j < 7; j++)
                    {
                        listeAnimal[IDsuprime, j] = null;
                    }
                    // mise à jour de la liste
                    for (int i = IDsuprime + 1; i < nombreAnimal; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {

                            listeAnimal[i - 1, j] = listeAnimal[i, j];
                        }
                    }
                    // après suppression diminuer le nombre d'animaux
                    nombreAnimal = nombreAnimal - 1;
                    // afficher la lste des animaux sans l'animal supprimé
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    Console.WriteLine("   ID   |   TYPE ANIMAL   |   NOM   |   AGE   |   POIDS   |   COULEUR   |   PROPRIÉTAIRE   |");
                    Console.WriteLine("--------------------------------------------------------------------------------------------");

                    for (int i = 0; i < nombreAnimal; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(listeAnimal[i, j] + "       \t");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("L'ID n'est pas dans la liste");
                }

                


            }

        }

        // Menu de gestion des différentes traitement
        public void MenuVeterinaire(int monChoix)
        {
            switch (monChoix)
            {
                case 1: AjouterAnimal();
                    break;
                case 2: AfficherTousAnimaux();
                    break;
                case 3: AfficherProprietaires();
                    break;
                case 4: AfficherTotalAnimaux();
                    break;
                case 5: AfficherPoidsTotalAnimaux();
                    break;
                case 6: AfficherAnimauxParCouleur();
                    break;
                case 7: RetirerAnimal();
                    break;
                case 8: Environment.Exit(0);
                    break;
                default: Console.WriteLine("Le choix n'est pas valide...");
                    break;
            }
        }


    }
}