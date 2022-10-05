using BatailleNavaleWPF;
using System;

namespace BatailleNavale
{
    // Classe abstrait qui sera implementée par les enfants
    public abstract class Navire : INavire
    {
        // Propriété qui devra etre modifié par les enfants
        public abstract int Taille { get; }

        // Proprité booléen qui retourne la sortie de la methode EstCoule()
        public bool Coule { get => EstCoule(); }

        private readonly Case[] cases;

        public Navire( Case[] carres)
        {
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
