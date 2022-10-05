using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur:Navire
    {
        // Variable d'intance avec la taille
        public const int Longueur = 3;

        // Constructeur de la classe
        public Patrouilleur(Case[] carre):base(carre)
        {
            Taille = Longueur;
        }
    }
}
