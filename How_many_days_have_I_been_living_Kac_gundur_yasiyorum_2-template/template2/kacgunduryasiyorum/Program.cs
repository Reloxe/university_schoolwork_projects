using System;

namespace kacgunduryasiyorum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Kaç Gündür Yaşıyorum ? ------");
            Console.WriteLine("Hoşgeldiniz, aşağıya doğum tarihinizi girerek kaç gündür yaşadığınızı öğrenebilirsiniz.");

            // Kullanıcıdan istiyoruz doğum tarihini ve değişkene atadık
            Console.Write("Doğum gününüzü girin-> ");
            int gun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Doğum ayınızı girin-> ");
            int ay = Convert.ToInt32(Console.ReadLine());

            Console.Write("Doğum yılınızı girin-> ");
            int yil = Convert.ToInt32(Console.ReadLine());


            DateTime suAnkiTarih = DateTime.Now;  // Şu anki tarihi aldık ve değişkene atadık


            DateTime dogumTarihi = new DateTime(yil, ay, gun);  // Doğum tarihini date time ile oluşturuyoruz.

            // Kaç gün yaşandığını hesapla
            int gecenGunSayisi = (suAnkiTarih - dogumTarihi).Days;
            DayOfWeek dogumGunu = dogumTarihi.DayOfWeek;

                    // Sonucu ekrana yazdır


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
            Console.WriteLine($"{gecenGunSayisi} gündür hayattasınız.");


            Console.ReadLine(); // Konsol penceresinin hemen kapanmamasını durdurmak için readline ile konsoldan gelecek girdiyi bekliyoruz.
        }
    }
}
