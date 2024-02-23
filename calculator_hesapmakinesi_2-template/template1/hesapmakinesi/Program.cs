using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi
{
    internal class Program
    {
        static void toplama() {
            Console.Write("İlk sayıyı girin-> ");
            int ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin-> ");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç-> " + (ilksayi + ikincisayi));
        }

        static void cikarma()
        {
            Console.Write("İlk sayıyı girin-> ");
            int ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin-> ");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç-> " + (ilksayi - ikincisayi));
        }

        static void carpma()
        {
            Console.Write("İlk sayıyı girin-> ");
            int ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin-> ");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç-> " + (ilksayi * ikincisayi));
        }

        static void bolme()
        {
            Console.Write("İlk sayıyı girin-> ");
            int ilksayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin-> ");
            int ikincisayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sonuç-> " + (ilksayi / ikincisayi));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("------ Hesap Makinesi ------");
            Console.WriteLine("Toplama İşlemi yapmak için 1");
            Console.WriteLine("Çıkarma İşlemi yapmak için 2");
            Console.WriteLine("Çarpma İşlemi yapmak için 3");
            Console.WriteLine("Bölme İşlemi yapmak için 4");

            Console.Write("Seçiminizi yapınız: ");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    toplama();
               break;
                case "2":
                    cikarma();
               break; 
                case "3":
                    carpma();
               break;
                case "4":
                    bolme();
               break;
                default:
                    Console.WriteLine("Hatalı Seçim yaptınız !");
                    break;
            }
            Console.ReadLine();

        }
    }
}
