using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budowniczy
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice_string;
            int choice_int = 1;
            //wybór pliku do odczytu
            while(true)
            {
                Console.WriteLine("Text do wyboru: (1) - Sport, (2) - Biznes, (3) - Rozrywka");
                choice_string = Console.ReadLine();
                if (int.TryParse(choice_string, out choice_int))
                {
                    if (choice_int > 0 && choice_int < 4) 
                        break;
                }
            }
            String filePath = "";
            if (choice_int == 1)
            {
                filePath = "text1.txt";
            }
            else if (choice_int == 2)
            {
                filePath = "text2.txt";
            }
            else //if(choice == 3)
            {
                filePath = "text3.txt";
            }

            StreamReader reader = new StreamReader(filePath);

            string text = reader.ReadToEnd();
            Console.WriteLine("\nText:");
            Console.WriteLine("\n"+text+"\n");
        
            Dyrektor szef = new Dyrektor();
            Budowniczy builderL = new BudowniczyList();
            Budowniczy builderD = new BudowniczyDictionary();

            //Budowa List
            Console.WriteLine("\nList");
            szef.setBuilder(builderL);
            szef.Buduj(text);
            Slownik slownikT = szef.getSlownik();
            slownikT.ShowSlownik();

            //Budowa Dictionary
            Console.WriteLine("\nDictionary");
            szef.setBuilder(builderD);
            szef.Buduj(text);
            Slownik slownikH = szef.getSlownik();
            slownikH.ShowSlownik();  

            Console.ReadLine();

        }
    }
}
