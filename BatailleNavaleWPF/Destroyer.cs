using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Destroyer : Navire
    {
        private const int Longueur = 2;

        public override int Taille
        {
            get { return Longueur; }
        }
        public Destroyer(Case[] carres) : base(carres)
        {

        }
    }
}
