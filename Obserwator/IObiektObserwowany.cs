using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    public interface IObiektObserwowany
    {
        void Dodaj(IObserwator o);
        void Usun(IObserwator o);
        void Powiadom();
    }
}
