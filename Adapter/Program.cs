using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> listAK = new AdapterKlasowy();
            listAK.Add("jeden");
            listAK.Add("dwa");
            listAK.Add("trzy");

            Console.WriteLine("Adapter Klasowy:");
            foreach (string item in listAK)
                Console.WriteLine(item);

            IList<string> listAO = new AdapterKlasowy();
            listAO.Add("jeden");
            listAO.Add("dwa");
            listAO.Add("trzy");

            Console.WriteLine("Adapter Obiektowy:");
            foreach (string item in listAO)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
