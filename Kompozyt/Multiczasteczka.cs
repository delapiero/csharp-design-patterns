using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    public class Multiczasteczka : ObiektWieloczasteczkowy 
    {
    
        private IList<ObiektWieloczasteczkowy> czasteczka;
    
        public Multiczasteczka()
        {
            czasteczka = new List<ObiektWieloczasteczkowy>();
        }

        public void przesuniecie(Wektor3d _v) 
        {
            foreach (ObiektWieloczasteczkowy o in czasteczka)
            {
                o.przesuniecie(_v);
            }
        }

        public double Masa 
        {
            get
            {
                double sumaMasy = 0;
                foreach (ObiektWieloczasteczkowy o in czasteczka)
                    sumaMasy += o.Masa;
                return sumaMasy;
            }
        }
    
        public int Zlozonosc
        {
            get
            {
                int zlozonosc = 0;
                foreach (ObiektWieloczasteczkowy o in czasteczka)
                    zlozonosc += o.Zlozonosc;
                return zlozonosc;
            }
        }
    
        public Wektor3d SrodekMasy
        {
            get
            {
                Wektor3d _v = new Wektor3d(0, 0, 0);
                double sumaMasy = 0;
                foreach (ObiektWieloczasteczkowy o in czasteczka)
                {
                    Wektor3d c = o.SrodekMasy;
                    _v.x += c.x * o.Masa;
                    _v.y += c.y * o.Masa;
                    _v.z += c.z * o.Masa;
                    sumaMasy += o.Masa;
                }
                _v.x /= sumaMasy;
                _v.y /= sumaMasy;
                _v.z /= sumaMasy;
                return _v;
            }
        }

        public Wektor3d SrodekGeometryczny
        {
            get
            {
                Wektor3d _v = new Wektor3d(0, 0, 0);
                int iloscCzastek = 0;
                foreach (ObiektWieloczasteczkowy o in czasteczka)
                {
                    Wektor3d c = o.SrodekGeometryczny;
                    iloscCzastek += o.Zlozonosc;
                    _v.x += c.x;
                    _v.y += c.y;
                    _v.z += c.z;
                }
                _v.x /= iloscCzastek;
                _v.y /= iloscCzastek;
                _v.z /= iloscCzastek;
                return _v;
            }
        }
    
        public void dodaj(ObiektWieloczasteczkowy o)
        {
            czasteczka.Add(o);
        }
    
        public void usun(ObiektWieloczasteczkowy o)
        {
            czasteczka.Remove(o);
        }
    
        public override string ToString()
        {
            string wynik = "";
            foreach (ObiektWieloczasteczkowy o in czasteczka)
            {
                wynik += o.ToString();
            }
            return wynik;
        }
    }
}
