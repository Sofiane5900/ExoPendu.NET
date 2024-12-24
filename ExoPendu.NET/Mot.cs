﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPendu.NET
{

    internal class Mot
    {

        private List<string> _motATrouverList;

        public List<string> motATrouverList { get { return _motATrouverList; } }

        public Mot (string motATrouverList)
        {
            _motATrouverList = new List<string> {"ordinateur" , "programmation" , "csharp" , "dotnet"};
        }

        // Je déclare une method qui return un string
        string GenererMot()
        {
            // J'instancie une variable random de type Random
            Random random = new Random();
            // Je déclare un int index qui prend un nombre aléatoire entre 0 et la taille de ma liste 
            int motRandom = random.Next(0, _motATrouverList.Count);
            return _motATrouverList[motRandom];

        }
    }
}
