using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvions:Navire
    {
        private const int Longueur = 5;

        public override int Taille
        {
            get { return Longueur; }
        }
        public PorteAvions(Case[] carre):base(carre)
        {

        }
    }
}
