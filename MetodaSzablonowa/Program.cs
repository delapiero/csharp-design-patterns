using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    class Program
    {
        static void Main(string[] args)
        {
            // mała firma
            Console.WriteLine("Mała firma:");
            ObiegDokumentowMalaFirma firma1 = new ObiegDokumentowMalaFirma("Jan Kowalski","Firma1");
            firma1.przyjecieDokumentu("Umowa", "Marcin Nowak");
            Dokument dok1 = firma1.dokumenty.ElementAt(0);
            dok1.drukuj();
        
            Console.WriteLine();
        
            // duza firma
            Console.WriteLine("Duża firma:");
            ObiegDokumentowDuzaFirma firma2 = new ObiegDokumentowDuzaFirma();
            // dział umow
            firma2.umowy = new Dzial();
            firma2.umowy.kierownik = "Tomasz Rak";
            firma2.umowy.pracownicy.Add("Joanna");
            firma2.umowy.pracownicy.Add("Jadwiga");
            // dzial reklamacji
            firma2.reklamacje = new Dzial();
            firma2.reklamacje.kierownik = "Remigiusz Rak";
            firma2.reklamacje.pracownicy.Add("Irena");
            firma2.reklamacje.pracownicy.Add("Piotr");
            // przyjecie dokumentu
            firma2.przyjecieDokumentu("Rozwiązanie umowy", "Marcin Nowak");
            Dokument dok2 = firma2.dokumenty.ElementAt(0);
            dok2.drukuj();

            Console.ReadLine();
        }
    }
}
