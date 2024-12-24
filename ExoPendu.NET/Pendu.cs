using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExoPendu.NET
{
    internal class Pendu
    {
        private string _masque;
        private int _nombreEssai;
        private string _motCacher;
        private char[] _charArray;
        private char[] _masqueArray;
        private bool _partieGagner;

        public string Masque
        {
            get => _masque;
            set => Masque = _masque;
        }
        public int NombreEssai
        {
            get => _nombreEssai;
            set => _nombreEssai = value;
        }
        public string MotCacher
        {
            get => _motCacher;
            set => _motCacher = value;
        }
        public bool PartieGagner
        {
            get => _partieGagner;
            set => _partieGagner = value;
        }

        public Pendu()
        {
            // L'utilisateur a 10 essais par default.
            _nombreEssai = 10;
        }

        public void GenererMasque()
        {
            // J'instancie un objet mot de type Mot
            Mot mot = new Mot();
            // J'utilise la méthode GenererMot() pour génerer un mot aléatoire dans ma variable motRandom
            string _motATrouver = mot.GenererMot();
            MotCacher = _motATrouver;
            // Je transforme mon _motATrouver en une variable tableau de type char
            _charArray = _motATrouver.ToCharArray();
            // Je déclare que _masqueArray est un nouveau tableau de caractères de la meme longueur que _charArray.Length
            _masqueArray = new string('*', _charArray.Length).ToCharArray(); // ToCharArray en tant que Méthode pour convertir une chaine en tableau de char[]
            // Je converti mon tableau de caractére en chaine de caractéres
        }

        public void TestChar()
        {
            // Tant que mon nombre d'essai est différent (!=) de 0
            while (PartieGagner == false && NombreEssai > 0)
            {
                Console.Write("Veuillez saisir une lettre : ");
                char c;
                bool sucessChar = char.TryParse(Console.ReadLine(), out c);
                if (!sucessChar)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veuillez entrer un caractére valide.");
                    Console.ResetColor();
                    continue;
                }

                for (int i = 0; i < _charArray.Length; i++)
                {
                    // A chaque itération, verifie que _charArray contiens le caractére de la saisie de l'user, et affiche un message.
                    if (_charArray[i] == c)
                    {
                        // Je remplace la saisie de l'utilisateur par la lettre correspondante dans le tableau
                        _masqueArray[i] = c;
                    }
                }
                // Je convertis mon tableau en une chaine de caractére pour pouvoir l'afficher.
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Le mot à trouver : {new string(_masqueArray)}");
                Console.ResetColor();
                NombreEssai--;
                AffichageEssai();
                TestWin();
            }
        }

        public void TestWin()
        {
            if (!_masqueArray.Contains('*'))
            {
                PartieGagner = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(
                    $"Bravo, vous avez gagner la partie! le mot caché etait {MotCacher}"
                );
                Console.ResetColor();
            }
        }

        public void AffichageEssai()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Il vous reste {NombreEssai} essais.");
            Console.ResetColor();
        }

        public void IHM()
        {
            while (true)
            {
                Console.WriteLine("=== Paramétres de partie ===\n");
                Console.Write("Voulez vous un nombre d'essais spécifique (10 par défaut) ? Y/N :");
                string choixEssaiDefault = Console.ReadLine();
                if (choixEssaiDefault == "Y")
                {
                    NombreEssai = 10;
                    break;
                }
                else if (choixEssaiDefault == "N")
                {
                    Console.Write("Combien voulez vous d'essais ? :");
                    int choixNombreEssai;
                    bool successChoixNombreEssai = int.TryParse(
                        Console.ReadLine(),
                        out choixNombreEssai
                    );
                    if (choixNombreEssai <= 0 || choixNombreEssai > 30)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Veuillez choisir un nombre d'essai entre 1 et 30.");
                        Console.ResetColor();
                        continue;
                    }
                    NombreEssai = choixNombreEssai;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous n'etes pas autorisé a effectuer cette action");
                    Console.ResetColor();
                }
            }
        }
    }
}
