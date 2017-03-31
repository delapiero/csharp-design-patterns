using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    public class Slownik
    {
        public bool isDefined { get; set; }
        public object lista { get; set; }
    
        public Slownik()
        {
            isDefined = false;
        }   
    
        //metoda wyswietla zawartosc produktu (sposob wyświetlenia jest rózny dla HashSet oraz SortedSet)
        public void ShowSlownik()
        {
            if(isDefined && lista != null)
            {
                if(lista is Dictionary<string,int>)
                {
                    Dictionary<string,int> dict = lista as Dictionary<string,int>;
                    List<string> list = dict.Keys.OrderBy(k => k).ToList<string>();
                    foreach(string key in list)
                        Console.WriteLine(
                            String.Format("{0}({1})",key,dict[key])
                            );
                }
                else if(lista is List<string>)
                {
                    List<string> list = (lista as List<string>).OrderBy(s => s).ToList<string>();
                    foreach (string s in list) 
                        Console.WriteLine(s);          
                }
                else
                {
                    Console.WriteLine("Type unknown");
                }  
            }
            else
            {
                Console.WriteLine("Slownik is not defined");
            }       
        }
    }
}
