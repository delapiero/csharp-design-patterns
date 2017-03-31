using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    public class BudowniczyList : Budowniczy
    {
        public override void Initialize()
        {
            slownik.lista = new List<string>();
            slownik.isDefined = true;
        }

        public override void AddWord(string s)
        {
            if(slownik.isDefined && slownik.lista != null)
                ((List<string>)slownik.lista).Add(s);
        }
    }
}
