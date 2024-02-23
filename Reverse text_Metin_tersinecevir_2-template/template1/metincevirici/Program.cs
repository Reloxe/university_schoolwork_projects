using System;

namespace metincevirici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Metni Tersine Çevirme ------");
            Console.Write("Lütfen bir metin girin-> ");

            // Kullanıcıdan metin alıyoruz
            string girilenMetin = Console.ReadLine();

            // Metni tersine çevir i çağırıp işlemi yaptırıyoruz.
            string tersineCevrilmisMetin = TersineCevir(girilenMetin);

            // Sonucu ekrana yazdır
            Console.WriteLine($"Tersine Çevrilmiş Metin: {tersineCevrilmisMetin}");

            Console.ReadLine(); // Konsol penceresinin kapanmasını engelliyoruz.
        }

        // Metni tersine çeviren fonksiyon
        static string TersineCevir(string metin)
        {
            char[] karakterDizisi = metin.ToCharArray();  // Metni arraya değişkenine atıyor
            Array.Reverse(karakterDizisi); ;  // tersine çeviriyor
            return new string(karakterDizisi); ;  // string olarak geri dönüş yapıyor tersine çevirip
        }
    }
}
