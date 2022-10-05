using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvions:Navire
    {
        public const int Longueur = 5;

        public PorteAvions(Case[] carre):base(carre)
        {
            Taille = Longueur;
        }
    }
}
