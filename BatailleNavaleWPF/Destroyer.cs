using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Destroyer : Navire
    {
        public const int Longueur = 2;

        public Destroyer(Case[] carres) : base(carres)
        {
            Taille = Longueur;
        }
    }
}
