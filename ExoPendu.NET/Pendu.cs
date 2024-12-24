using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExoPendu.NET
{

    internal class Pendu
    {
        private string _masque;
        private int _nombreEssai;
        private string motCacher;

        public string masque { get => _masque; set => masque = _masque; }
        public int nombreEssai { get => _nombreEssai; set => nombreEssai = _nombreEssai; }


        public Pendu()
        {
            GenererMasque();
            _masque = masque;
            _nombreEssai = nombreEssai;
        }

        void GenererMasque()
        {
            // J'instancie un objet mot de type Mot
            Mot mot = new Mot();
            // J'utilise la méthode GenererMot() pour génerer un mot aléatoire dans ma variable motRandom
            string _motATrouver = mot.GenererMot();
            // Je déclare que mon masque est un new string "*" de la taille de mon motRandom
            motCacher = new string('*', _motATrouver.Length);
        }

       public void TestChar()
        {
            Console.WriteLine($"Le mot à trouver : {motCacher}");
        }
    }
}