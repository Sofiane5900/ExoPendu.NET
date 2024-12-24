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
        private string motCacher;
        private string _lettresTrouver;
        private char[] _charArray;
        private char[] _masqueArray;


        public string Masque { get => _masque; set => Masque = _masque; }
        public int NombreEssai { get => _nombreEssai; set => NombreEssai = _nombreEssai; }
        public string LettresTrouver { get => _lettresTrouver; set => _lettresTrouver = value; }

     
      

        public Pendu()
        {
            
            
            // L'utilisateur a 10 vies.
            _nombreEssai = 10;
            // Je crée une nouvelle chaine de caractére en utilisant les caractéres dans CharArray
  ;

        }
         
       public void GenererMasque()
        {
            // J'instancie un objet mot de type Mot
            Mot mot = new Mot();
            // J'utilise la méthode GenererMot() pour génerer un mot aléatoire dans ma variable motRandom
            string _motATrouver = mot.GenererMot();
            motCacher = _motATrouver;
            // Je transforme mon _motATrouver en une variable tableau de type char
            _charArray = _motATrouver.ToCharArray();
            // Je déclare que _masqueArray est un nouveau tableau de caractères de la meme longueur que _charArray.Length 
            _masqueArray = new string ('*', _charArray.Length).ToCharArray(); // ToCharArray en tant que Méthode pour convertir une chaine en tableau de char[]
            // Je converti mon tableau de caractére en chaine de caractéres
            Console.WriteLine($"Le mot à trouver : {new string(_masqueArray)}");
        }

        public void TestChar()
        {
            
            // Tant que mon nombre d'essai est différent (!=) de 0 
            while (NombreEssai != 0)
            {
            
            Console.Write("Veuillez saisir une lettre : ");
            char c;
            bool sucessChar = char.TryParse(Console.ReadLine(), out c);
            if(!sucessChar)
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
                    if( _charArray[i] == c)
                    {
                        // Je remplace la saisie de l'utilisateur par la lettre correspondante dans le tableau 
                        _masqueArray[i] = c;
                        // Je convertis mon tableau en une chaine de caractére pour pouvoir l'afficher.
                        Console.WriteLine($"Le mot caché contient bien ce caractére {new string(_masqueArray)}");
                    }

                }
            }
        }

        
        public void TestWin()
        {

        }
    }
}