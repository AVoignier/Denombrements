///Titre : Denombrement
///Description : Propose à l'utilisateur de calculer des solutions à des problèmes combinatoire
///Auteur : ? / Alexandre Voignier
///Date de création : ?
///Date de modification : 01/10/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                choix = saisieValeur("Choix :                            ");

                switch (choix)
                {
                    // Si l'utilisateur veut quitter
                    case 0:
                        break;

                    // Si l'utilisateur veur calculer les permutations
                    case 1:
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nombreElements = int.Parse(Console.ReadLine());
                        long r = factorielle(nombreElements);
                        Console.WriteLine(nombreElements + "! = " + r);
                        break;

                    // Si l'utilisateur veut calculer les arrangement
                    case 2:
                        int nbTotalElements = saisieValeur("nombre total d'éléments à gérer = ");
                        int nbElementsSousEnsemble = saisieValeur("nombre d'éléments dans le sous ensemble = ");
                        long resultat = 1;
                        for (int k = (nbTotalElements - nbElementsSousEnsemble + 1); k <= nbTotalElements; k++)
                        {
                            resultat *= k;
                        }
                        Console.WriteLine("A(" + nbTotalElements + "/" + nbElementsSousEnsemble + ") = " + resultat);
                        break;

                    //Si l'utilisateur veut calculer les combinaisons
                    case 3:
                        int t = saisieValeur("nombre total d'éléments à gérer = ");
                        int n = saisieValeur("nombre d'éléments dans le sous ensemble = ");
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                        {
                            r1 *= k;
                        }
                        long r2 = factorielle(n);
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        break;

                    default:
                        Console.WriteLine("Valeur non valide , veuillez refaire votre choix");
                        break;

                }
            }
        }

        /// Fonction : 
        ///     Procédure renvoyant un entier saisie par l'utilisateur.
        ///      La demande se fait en boucle tant que l'utilisateur n'a pas rentré d'entier et lui affiche un message d'erreur
        /// Variables
        ///     valeur : entier représentant la valeur saisie par l'utilisateur
        ///    correct : booléen servant à vérifier si la demande de rentrer un nombre entier doit recommencer
        static int saisieValeur(string message)
        {
            bool correct = false;
            int valeur = 0;

            while (!correct)
            {
                try
                {
                    Console.Write(message);
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.Write("La valeur saisie doit être un entier");
                }
            }

            return valeur;

        }

        /// Fonction : 
        ///     Procédure renvoyant la factorielle de la valeur entrée par l'utilisateur
        /// Variables
        ///     valeur : entier représentant la valeur saisie par l'utilisateur
        ///     resultat : resultat de la factorielle
        ///     ite : Itérateur de la boucle de calcul
        static int factorielle(int valeur)
        {
            int resultat = 1;

            for (int ite = 1; ite <= valeur; ite++)
            {
                resultat *= ite;
            }

            return resultat;
        }

    }
}
