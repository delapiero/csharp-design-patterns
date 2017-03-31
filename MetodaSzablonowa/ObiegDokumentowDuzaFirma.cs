using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public class ObiegDokumentowDuzaFirma : ObiegDokumentow
    {
        public Dzial umowy { get; set; }
        public Dzial reklamacje { get; set; }
    
        public ObiegDokumentowDuzaFirma(){}
    
        protected override void skierowanieDokumentu(Dokument dok)
        {
            if ( dok.rodzaj == "Umowa" || dok.rodzaj == "Rozwiązanie umowy")
            {
                dok.pracownik = umowy.kierownik;
                dok.dzial = umowy;
                dok.status += "Skierowano do działu umów.\n";
            } 
            else if ( dok.rodzaj == "Reklamacja")
            {
                dok.pracownik = reklamacje.kierownik;
                dok.dzial = reklamacje;
                dok.status += "Skierowano do działu reklamacji.\n";
            }
        }
    
        protected override void rozpatrzenieDokumentu(Dokument dok)
        {
            dok.pracownik = dok.dzial.przydzielPracownika();
            if ( dok.rodzaj == "Umowa")
            {
                dok.status += "Do podpisu.\n";    
            } 
            else if ( dok.rodzaj == "Rozwiązanie umowy")
            {
                Random r = new Random();
                dok.status = "Pozostała należność: " + r.Next(500) + ".\n";  
            } 
            else if ( dok.rodzaj == "Reklamacja")
            {
                Random r = new Random();
                dok.status = "Rozpatrzono " + (r.Next(0, 2) == 0 ? "pozytywnie" : "negatywnie") + ".\n";
            }
        }
    
        protected override void podpisDokumentu(Dokument dok)
        {   
            dok.podpis = dok.dzial.kierownik;
            dok.status += "Podpisano.\n";
        }
    
        protected override void zwrotDokumentu(Dokument dok){
            dok.status += "Skierowano do zwrotu.\n";
            base.zwrotDokumentu(dok);
        }  
    }
}
