using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    public class Obserwowany: IObiektObserwowany
    {
        private IList<IObserwator> obserwatorzy;

        public IList<double> wartosci { get; set; }

        public Obserwowany()
        {
            obserwatorzy = new List<IObserwator>();
            wartosci = new List<double>();
        }

        public void Dodaj(IObserwator o)
        {
            if (!obserwatorzy.Contains(o))
                obserwatorzy.Add(o);
        }

        public void Usun(IObserwator o)
        {
            if (obserwatorzy.Contains(o))
                obserwatorzy.Remove(o);
        }

        public void Powiadom()
        {
            foreach (IObserwator o in obserwatorzy)
                o.Aktualizuj(this);
        }
    }
}
