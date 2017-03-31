using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    public class Czasteczka : ObiektWieloczasteczkowy 
    {
        private Wektor3d v;
        private double masa; 
    
        public Czasteczka(Wektor3d _v, double _masa)
        {
            v = _v;
            masa = _masa;
        }

        public void przesuniecie(Wektor3d _v)
        {
            v.x += _v.x;
            v.y += _v.y;
            v.z += _v.z;
        }

        public double Masa 
        {
            get { return masa; }
        }
    
        public int Zlozonosc
        {
            get { return 1; }
        }
    
        public Wektor3d SrodekMasy
        {
            get { return v; }
        }

        public Wektor3d SrodekGeometryczny
        {
            get { return v; }
        }
    
        public override string ToString()
        {
            return v.x + " " + v.y + " " + v.z + " - " + masa + "\n";
        }
    }
}
