using System;

namespace kacgundurhayattayim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#  Kaç Gündür Yaşıyorum #");
            Console.WriteLine("Merhaba, Aşağıya doğum tarihinizi giriniz.");


            Console.Write("Doğum gününüzü girin: ");
            int girdi_gun = Convert.ToInt32(Console.ReadLine());  // Girdi istiyoruz burada ve değişkene atıyoruz.
            Console.Write("Doğum ayınızı girin: ");
            int girdi_ay = Convert.ToInt32(Console.ReadLine()); // Girdi istiyoruz burada ve değişkene atıyoruz.
            Console.Write("Doğum yılınızı girin: ");
            int girdi_yil = Convert.ToInt32(Console.ReadLine());  // Girdi istiyoruz burada ve değişkene atıyoruz. 

            DateTime suankitarih = DateTime.Now;  // şuanki tarihi alıp değere atık

            DateTime dogumTarihi = new DateTime(girdi_yil, girdi_ay, girdi_gun);  // Doğum tarihini date time ile oluşturup değişkene atadık.

            // hesaplama kismi
            int gunsayisi = (suankitarih - dogumTarihi).Days;
            DayOfWeek dogumGunu = dogumTarihi.DayOfWeek;

            // Sonucu yaz

            switch (dogumGunu)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine($"Pazar günü doğdunuz.");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine($"Pazartesi günü doğdunuz.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine($"Salı günü doğdunuz.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine($"Çarşamba günü doğdunuz.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine($"Perşembe günü doğdunuz.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine($"Cuma günü doğdunuz.");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine($"Cumartesi günü doğdunuz.");
                    break;
                default:
                    break;
            }
            Console.WriteLine(gunsayisi + " gündür hayattasınız.");
            Console.ReadLine(); 
            // Konsol penceresinin hemen kapanmamasını engelliyoruz
        }
    }
}
