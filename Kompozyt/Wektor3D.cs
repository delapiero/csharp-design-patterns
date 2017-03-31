using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    public class Wektor3d
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Wektor3d(double _x, double _y, double _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public Wektor3d(Wektor3d _v)
        {
            x = _v.x;
            y = _v.y;
            z = _v.z;
        }

        public override String ToString()
        {
            return x + " " + y + " " + z + "\n";
        }
    }
}
