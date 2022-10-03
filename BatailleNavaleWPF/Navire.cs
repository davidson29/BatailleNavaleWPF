using BatailleNavaleWPF;
using System;

namespace BatailleNavale
{
    public abstract class Navire : INavire
    {
        public abstract int Taille { get; }
        public bool Coule { get => EstCoule(); }

        private readonly Case[] cases;

        public Navire( Case[] carres)
        {
            //Taille = taille;
            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        private bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
