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
        public const int Longueur = 4;

        // Propriete aui retourne la taille du navire

        // Constructeur de la classe
        public Cuirasse(Case[] cases) : base(cases)
        {
            Taille = Longueur;
        }
    }
}
