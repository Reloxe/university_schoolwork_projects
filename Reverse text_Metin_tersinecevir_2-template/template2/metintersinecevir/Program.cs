using System;
using System.Linq;

namespace metintersinecevir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Metni Tersine Çevirme #");
            Console.Write("Lütfen bir metin girin: ");

       
            string girilenMetin = Console.ReadLine();     // Kullanıcıdan metin alıyoruz
            char[] karakterleri = girilenMetin.ToCharArray(); // alınan veriyi karaklteri dizinine atıyoruz
            Array.Reverse(karakterleri); // tersine ceviriyoruz
            string sonmetin = string.Join("", karakterleri);


            // Sonucu ekrana yazdır
            Console.WriteLine("Tersine Çevrilmiş Metin: " + sonmetin);

            Console.ReadLine();
        }

    }
}
