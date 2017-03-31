using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obserwator
{
    class ViewModel
    {
        public Obserwowany Obserwowany { get; set; }
        public ObserwatorA ObserwatorA { get; set; }
        public ObserwatorB ObserwatorB { get; set; }

        private bool a;
        public bool A 
        {
            get 
            { 
                return a; 
            }
            set
            {
                a = value;
                if (a)
                    Obserwowany.Dodaj(ObserwatorA);
                else
                    Obserwowany.Usun(ObserwatorA);
            }
        }

        private bool b;
        public bool B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                if (b)
                    Obserwowany.Dodaj(ObserwatorB);
                else
                    Obserwowany.Usun(ObserwatorB);
            }
        }

        public ViewModel()
        {
            Obserwowany = new Obserwowany();
            ObserwatorA = new ObserwatorA();
            ObserwatorB = new ObserwatorB();
            A = true;
            B = true;
        }
    }
}
