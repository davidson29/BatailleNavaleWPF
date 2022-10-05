using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class SousMarin:Navire
    {
        // Variable d'intance avec la taille
        public const int Longueur = 1;

        // Constructeur de la classe
        public SousMarin(Case[] carres):base(carres)
        {
            Taille = Longueur;    
        }
    }
}
