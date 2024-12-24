using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExoPendu.NET
{

    internal class Pendu
    {
        private string _masque;
        private int _nombreEssai;

        public string masque { get => _masque; set => masque = _masque; }
        public int nombreEssai { get => _nombreEssai; set => nombreEssai = _nombreEssai; }


        public Pendu(string masque, int nombreEssai)
        {
            _masque = masque;
            _nombreEssai = nombreEssai;
        }

        void GenererMasque()
        {
            Mot mot = new Mot();
            string motRandom = mot.GenererMot();

            for (int i = 0; i < motRandom.Length; i++)
            {

            }
        }
    }
}