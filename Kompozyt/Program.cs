using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompozyt
{
    class Program
    {
        static void Main(string[] args)
        {
            // czasteczki
            Console.WriteLine("Czasteczki proste:");
            ObiektWieloczasteczkowy c1 = new Czasteczka(new Wektor3d(1,1,1), 1);
            ObiektWieloczasteczkowy c2 = new Czasteczka(new Wektor3d(2,2,2), 1);
            Console.Write(c1.ToString());
            Console.Write(c2.ToString());
        
            // multiczasteczki
            Console.WriteLine("Multiczasteczki:");
            ObiektWieloczasteczkowy m1 = new Czasteczka(new Wektor3d(0,0,0), 2);
            ObiektWieloczasteczkowy m2 = new Czasteczka(new Wektor3d(0,2,0), 1);
            ObiektWieloczasteczkowy m3 = new Czasteczka(new Wektor3d(2,0,0), 1);
            ObiektWieloczasteczkowy m4 = new Czasteczka(new Wektor3d(2,2,0), 1);
            ObiektWieloczasteczkowy m5 = new Czasteczka(new Wektor3d(3,3,0), 1);
        
            Multiczasteczka M1 = new Multiczasteczka();
            M1.dodaj(m1);
            M1.dodaj(m2);
            M1.dodaj(m3);
            Multiczasteczka M2 = new Multiczasteczka();
            M2.dodaj(m4);
            M2.dodaj(m5);
            M2.dodaj(M1);
            Console.Write(M1.SrodekGeometryczny);
            Console.Write(M1.SrodekMasy);
        
            //obiekt wieloczasteczkowy
            Console.WriteLine("Obiekty wieloczasteczkowe:");
            IList<ObiektWieloczasteczkowy> tab = new List<ObiektWieloczasteczkowy>();
            tab.Add(c1);
            tab.Add(c1);
            tab.Add(M2);
        
            for(int i=0; i<tab.Count; ++i)
            {
                Console.WriteLine("tab " + i + ":");
                tab.ElementAt(0).przesuniecie(new Wektor3d(1,1,1));
                Console.Write(tab.ElementAt(i).ToString());
            }

            Console.ReadLine();
        }
    }
}
