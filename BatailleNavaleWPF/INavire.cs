using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public interface INavire
    {
        int Taille { get; }
        bool Coule { get; }

    }
}
