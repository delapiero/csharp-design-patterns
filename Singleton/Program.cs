using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        // ID konfiguracji cały czas takie samo (osobne dla poznej i dla wczesnej inicjalizacji)
        static void Main(string[] args)
        {
            bool program = true;
            string wybor = "";

            while (program)
            {
                Console.WriteLine("1 - Zapisz konfigurację (wczesna inicjalizacja)");
                Console.WriteLine("2 - Wczytaj konfigurację (wczesna inicjalizacja)");
                Console.WriteLine("3 - Zapisz konfigurację (wczesna inicjalizacja)");
                Console.WriteLine("4 - Wczytaj konfigurację (wczesna inicjalizacja)");
                Console.WriteLine("5 - Wyjdz");

                wybor = Console.ReadLine();

                if (wybor == "1")
                {
                    KonfiguracjaWI konfiguracja = KonfiguracjaWI.getInstance();
                    Console.Write("Login: ");
                    konfiguracja.login = Console.ReadLine();
                    Console.Write("Haslo: ");
                    konfiguracja.haslo = Console.ReadLine();
                    konfiguracja.zapis();
                }
                else if (wybor == "2")
                {
                    KonfiguracjaWI konfiguracja = KonfiguracjaWI.getInstance();
                    konfiguracja.odczyt();
                    konfiguracja.drukuj();
                }
                else if (wybor == "3")
                {
                    KonfiguracjaPI konfiguracja = KonfiguracjaPI.getInstance();
                    Console.Write("Login: ");
                    konfiguracja.login = Console.ReadLine();
                    Console.Write("Haslo: ");
                    konfiguracja.haslo = Console.ReadLine();
                    konfiguracja.zapis();
                }
                else if (wybor == "4")
                {
                    KonfiguracjaPI konfiguracja = KonfiguracjaPI.getInstance();
                    konfiguracja.odczyt();
                    konfiguracja.drukuj();
                }
                else if (wybor == "5")
                {
                    program = false;
                }
            }
        }
    }
}
