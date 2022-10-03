using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class SousMarin:Navire
    {
        private const int Longueur = 1;

        public override int Taille
        {
            get { return Longueur; }
        }
        public SousMarin(Case[] carres):base(carres)
        {
                
        }
    }
}
