﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur:Navire
    {
        public const int Longueur = 3;

        public Patrouilleur(Case[] carre):base(carre)
        {
            Taille = Longueur;
        }
    }
}
