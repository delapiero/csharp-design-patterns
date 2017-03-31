using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    public abstract class Budowniczy
    {
        protected Slownik slownik;

        public void newSlownik()
        {
            slownik = new Slownik();
            Initialize();
        }

        public Slownik getSlownik()
        {
            return slownik;
        }

        public abstract void Initialize();
        public abstract void AddWord(String s);
    }
}
