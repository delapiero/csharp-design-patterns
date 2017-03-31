using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Budowniczy
{
    class Dyrektor
    {
        private Budowniczy builder;
        //slowo minium 2 znaki i tylko litery alfabetu (bez cyfr)
        private Regex r = new Regex("[a-zA-Z]{2,}", RegexOptions.IgnoreCase);

        //wyznaczenie konkretnego budowniczego
        public void setBuilder(Budowniczy builder)
        {
            this.builder = builder;
        }

        //odbór produktu końcowego od budowniczego
        public Slownik getSlownik()
        {
            return builder.getSlownik();
        }

        //nakazanie budowy produktu przez wybranego budowniczego
        public void Buduj(String text)
    {
        builder.newSlownik();
        string[] splitString = (text.Split(' '));
        foreach (string s in splitString) 
        {
            if(r.Match(s).Success) 
            {
                builder.AddWord(s);
            }                
        }
    }

    }
}
