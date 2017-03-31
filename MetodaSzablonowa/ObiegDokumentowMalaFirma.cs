using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public class ObiegDokumentowMalaFirma : ObiegDokumentow 
    {
        public Dzial firma { get; set; }
    
        public ObiegDokumentowMalaFirma(string _wlasciciel, string _nazwaFirmy)
        {
            firma = new Dzial();
            firma.kierownik = _wlasciciel;
            firma.nazwa = _nazwaFirmy;
        }
    
        protected override void skierowanieDokumentu(Dokument dok)
        {
            dok.pracownik = firma.kierownik;
            dok.dzial = firma;
        }
    
        protected override void rozpatrzenieDokumentu(Dokument dok)
        {
            if ( dok.rodzaj == "Umowa")
            {
                dok.status = "Do podpisu.\n";
            } 
            else if ( dok.rodzaj == "Rozwiązanie umowy")
            {
                Random r = new Random();
                dok.status = "Pozostała należność: " + r.Next(500) + ".\n";
            } 
            else if ( dok.rodzaj == "Reklamacja")
            {
                Random r = new Random();
                dok.status = "Rozpatrzono " + (r.Next(0,2) == 0 ? "pozytywnie" : "negatywnie") + ".\n";
            }
        }
    
        protected override void podpisDokumentu(Dokument dok)
        {
            base.podpisDokumentu(dok);
        }
    
        protected override void zwrotDokumentu(Dokument dok)
        {
            base.zwrotDokumentu(dok);
        }  
    }
}
