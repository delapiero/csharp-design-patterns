using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public abstract class ObiegDokumentow 
    {
        public IList<Dokument> dokumenty { get; set; }
    
        public ObiegDokumentow()
        {
            dokumenty = new List<Dokument>();
        }
    
        public void przyjecieDokumentu(string rodzaj, string nadawca)
        {
            // wstepne utworzenie dokumentu
            Dokument dok = new Dokument();
            dok.data = DateTime.Now;
            dok.rodzaj = rodzaj;
            dok.nadawca = nadawca;
            dok.status = "";
            dokumenty.Add(dok);
        
            // obieg doumentu
            skierowanieDokumentu(dok);
            rozpatrzenieDokumentu(dok);
            podpisDokumentu(dok);
            zwrotDokumentu(dok);
        }
    
        protected virtual void skierowanieDokumentu(Dokument dok){ }

        protected virtual void rozpatrzenieDokumentu(Dokument dok) { }

        protected virtual void podpisDokumentu(Dokument dok)
        {
            dok.podpis = dok.pracownik;
            dok.status += "Podpisano.\n";
        }

        protected virtual void zwrotDokumentu(Dokument dok)
        {
            if ( !String.IsNullOrEmpty(dok.podpis))
                dok.status += "Zwrot do nadawcy.\n";
        }

    }

}
