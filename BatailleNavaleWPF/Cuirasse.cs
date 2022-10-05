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

        // Constructeur de la classe
        public Cuirasse(Case[] cases) : base(cases)
        {
            Taille = Longueur;
        }
    }
}
