using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class KonfiguracjaWI 
    {
        private static KonfiguracjaWI instance = new KonfiguracjaWI();
        public int id = 0;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    
        //ustawienia
        public string login     { get; set; }
        public string haslo     { get; set; }
    
        private string plik = "config.txt";
 
        private KonfiguracjaWI() 
        {
            Random r = new Random();
            id = r.Next()+1;
        }
 
        public static KonfiguracjaWI getInstance() {
            return instance;
        }

        public void zapis()
        {
            StreamWriter zapis = null;
            try
            {
                zapis = new StreamWriter(plik, false);
                zapis.WriteLine(login);
                zapis.WriteLine(haslo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (zapis != null) zapis.Close();
            }
        }

        public void odczyt()
        {
            StreamReader odczyt = null;
            try
            {
                if (File.Exists(plik))
                {
                    odczyt = new StreamReader(plik);
                    login = odczyt.ReadLine();
                    haslo = odczyt.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (odczyt != null) odczyt.Close();
            }
        }

        public void drukuj()
        {
            Console.WriteLine(
                String.Format("Konfiguracja Id: {0}\nLogin: {1}\nHaslo: {2}", 
                id, login, haslo));
        }
    }
}
