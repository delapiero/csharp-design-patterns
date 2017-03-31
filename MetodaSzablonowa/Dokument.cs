using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaSzablonowa
{
    public class Dokument
    {
        public string rodzaj    { get; set; }
        public string nadawca   { get; set; }
        public DateTime data    { get; set; }

        public string status    { get; set; }

        public Dzial dzial      { get; set; }
        public string pracownik { get; set; }
        public string podpis    { get; set; }

        public void drukuj()
        {
            Console.WriteLine(rodzaj);
            Console.WriteLine(nadawca);
            Console.WriteLine(data.ToString());
            Console.WriteLine(status);
            Console.WriteLine(podpis);
        }
    }
}
