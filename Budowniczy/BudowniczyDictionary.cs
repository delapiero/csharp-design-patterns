using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    public class BudowniczyDictionary : Budowniczy
    {
        public override void Initialize()
        {
            //zaincjalizowanie klasy
            slownik.lista = new Dictionary<string,int>();
            slownik.isDefined = true;
        }

        public override void AddWord(String s)
        {
            if(slownik.isDefined && slownik.lista != null)
            {
                //jesli jest to nowe słowo to dodanie z wartoscą 1 (ilość wystopień)
                if(!((Dictionary<string,int>)slownik.lista).ContainsKey(s)) 
                {
                    ((Dictionary<string, int>)slownik.lista).Add(s, 1);
                }
                //jesli słowo pojawia sie po raz kolejny to wykasowanie pozycji i dodanie jeszcze raz inkrementując ilość wystapień
                else
                {
                    ((Dictionary<string, int>)slownik.lista)[s]++;
                }
            }
        }
    }
}
