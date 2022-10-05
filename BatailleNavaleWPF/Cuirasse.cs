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
        // Variable d'intance avec la taille
        private const int Longueur = 4;

        // Propriete aui retourne la taille du navire
        public override int Taille
        {
            get { return Longueur; }
        }

        // Constructeur de la classe
        public Cuirasse(Case[] cases) : base(cases)
        {
        }
    }
}
