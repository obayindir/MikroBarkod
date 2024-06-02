
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MikroBarkod.Services
{
    public class DosyaOku
    {

        public static string DbOku()
        {
            try
            {
                string dosyaYolu = Path.Combine(Application.StartupPath, "database.ini");
                using (StreamReader sr = new StreamReader(dosyaYolu))
                {
                    // Dosyanın tamamını okuyup bir string olarak döndürüyoruz
                    string dosyaIcerigi = sr.ReadToEnd();
                    return dosyaIcerigi;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda hatayı yakalayıp ekrana yazdırıyoruz
                Console.WriteLine("Hata: " + ex.Message);
                return null;
            }
        }


    }
}
