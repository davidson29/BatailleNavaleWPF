using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur:Navire
    {
        private const int Longueur = 3;

        public override int Taille
        {
            get { return Longueur; }
        }
        public Patrouilleur(Case[] carre):base(carre)
        {

        }
    }
}
