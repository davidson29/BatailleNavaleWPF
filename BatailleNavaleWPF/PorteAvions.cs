using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvions:Navire
    {
        // Variable d'intance avec la taille
        public const int Longueur = 5;

        // Constructeur de la classe
        public PorteAvions(Case[] carre):base(carre)
        {
            Taille = Longueur;
        }
    }
}
