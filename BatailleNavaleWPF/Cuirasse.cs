using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatailleNavale;

namespace BatailleNavale
{
    class Cuirasse : Navire
    {
        private const int Longueur = 4;

        public override int Taille
        {
            get { return Longueur; }
        }
        public Cuirasse(Case[] cases) : base(cases)
        {
        }
    }
}
