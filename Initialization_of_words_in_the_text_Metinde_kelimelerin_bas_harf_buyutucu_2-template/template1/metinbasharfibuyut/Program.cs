using System;

namespace metinbasharfibuyut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Her Kelimenin Baş Harfini Büyütme ------");
            Console.WriteLine("Lütfen bir metin girin-> ");

            // Kullanıcıdan metni al
            string girilenMetin = Console.ReadLine();

            // Her kelimenin baş harfini büyüterek yazdır
            string sonuc = BuyukBasHarf(girilenMetin);

            // Sonucu ekrana yazdır
            Console.WriteLine($"Baş harfi büyük hali: {sonuc}");

            Console.ReadLine(); // Konsol penceresinin hemen kapanmaması için bekletme
        }

        // Her kelimenin baş harfini büyüten fonksiyon
        static string BuyukBasHarf(string metin)
        {
            string[] kelimeler = metin.Split(' ');

            for (int i = 0; i < kelimeler.Length; i++)
            {
                // Her kelimenin baş harfini büyük yap
                if (!string.IsNullOrEmpty(kelimeler[i]))
                {
                    char[] karakterler = kelimeler[i].ToCharArray();
                    karakterler[0] = char.ToUpper(karakterler[0]);
                    kelimeler[i] = new string(karakterler);
                }
            }

            // Yeni metni birleştir
            return string.Join(" ", kelimeler);
        }
    }
}
