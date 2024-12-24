using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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
        private string _lettreRestantes;
        private char[] charArray; 

        public string Masque { get => _masque; set => Masque = _masque; }
        public int NombreEssai { get => _nombreEssai; set => NombreEssai = _nombreEssai; }
        public string LettreRestantes { get => _lettreRestantes; set => _lettreRestantes = value; }

      

        public Pendu()
        {
            GenererMasque();
            _masque = Masque;
            _nombreEssai = NombreEssai;
            _lettreRestantes= LettreRestantes;
        }

        void GenererMasque()
        {
            // J'instancie un objet mot de type Mot
            Mot mot = new Mot();
            // J'utilise la méthode GenererMot() pour génerer un mot aléatoire dans ma variable motRandom
            string _motATrouver = mot.GenererMot();
            // Je transforme mon _motATrouver en une variable tableau de type char
            char[] charArray = _motATrouver.ToCharArray();
        }

       public void TestChar(char c)
        {
            
            // Tant que mon nombre d'essai est différent (!=) de 0 
            while (NombreEssai != 0)
            {
            int LettreRestantes = 0;
            Console.Write("Veuillez saisir une lettre : ");
            bool sucessChar = char.TryParse(Console.ReadLine(), out c);
            if(!sucessChar)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Veuillez entrer un caractére valide.");
                    Console.ResetColor();
                    break;
                }
            foreach (char characters in motCacher)
                {
                    charArray[characters] = characters;
                    LettreRestantes++;
                    NombreEssai--;
                }
            }
        }

        //Console.WriteLine($"Le mot à trouver : {motCacher}");
        public void TestWin()
        {

        }
    }
}