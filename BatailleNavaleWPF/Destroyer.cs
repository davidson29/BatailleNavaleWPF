using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Destroyer : Navire
    {
        // Variable d'intance avec la taille
        public const int Longueur = 2;

        // Constructeur de la classe
        public Destroyer(Case[] carres) : base(carres)
        {
            Taille = Longueur;
        }
    }
}
