using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public class Dzial
    {
        public string nazwa { get; set; }
        public string kierownik { get; set; }
        public IList<string> pracownicy { get; set; }

        public Dzial()
        {
            pracownicy = new List<string>();
        }

        public String przydzielPracownika()
        {
            String pracownik;
            if (pracownicy.Count == 0)
            {
                pracownik = kierownik;
            }
            else
            {
                Random r = new Random();
                int nr = r.Next(pracownicy.Count - 1);
                pracownik = pracownicy.ElementAt(nr);
            }
            return pracownik;
        }
    }
}
