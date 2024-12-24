using System;
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

        void GenererMot()
        {
            Random random = new Random();
            int index = random.Next(0, 4);
        }
    }
}
