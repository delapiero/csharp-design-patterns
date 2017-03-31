using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    public interface ObiektWieloczasteczkowy 
    {
        void przesuniecie(Wektor3d _v);
        double Masa { get; }
        int Zlozonosc { get; }
        Wektor3d SrodekMasy { get; }
        Wektor3d SrodekGeometryczny { get; }
        string ToString();
    }
}
