using System;

namespace metinbasharfibuyutucu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Her Kelimenin Baş Harfini Büyütme #");
            Console.WriteLine("Lütfen bir metin girin: ");

            string girilenMetin = Console.ReadLine();    // Kullanıcıdan metni alıyoruz değere atadık

            string[] kelimeler = girilenMetin.Split(' ');
            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (!string.IsNullOrEmpty(kelimeler[i]))
                {
                    char[] karakterler = kelimeler[i].ToCharArray();
                    karakterler[0] = char.ToUpper(karakterler[0]);
                    kelimeler[i] = new string(karakterler);
                }
            }

            string sonmetin = string.Join(" ", kelimeler);

            Console.WriteLine($"Çevrilen metin: " + sonmetin);

            Console.ReadLine(); 
        }


    }
}
