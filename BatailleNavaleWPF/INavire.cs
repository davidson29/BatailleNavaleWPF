using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public interface INavire
    {
        // Propriété qui devrait etre implementé par l'enfant 
        int Taille { get; set; }

        // Propriété qui devrait etre implementé par l'enfant 
        bool Coule { get; }

        // Methode qui sera implémentée par Navire()
        bool EstCoule();
    }
}