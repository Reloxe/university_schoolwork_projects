using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesaplayici
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("# Hesap Makinesi #");
            Console.WriteLine("Toplama İşlemi için | 1");
            Console.WriteLine("Çıkarma İşlemi için | 2");
            Console.WriteLine("Çarpma İşlemi için | 3");
            Console.WriteLine("Bölme İşlemi için | 4");

            Console.Write("Seçiminizi yapınız: ");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.Write("İlk sayı:  ");
                    int ilksayi = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İkinci sayı:  ");
                    int ikincisayi = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem sonucu: " + (ilksayi + ikincisayi));
                    break;
                case "2":
                    Console.Write("İlk sayı:  ");
                    int ilksayii = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İkinci sayı:  ");
                    int ikincisayii = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem sonucu: " + (ilksayii - ikincisayii));
                    break;
                case "3":
                    Console.Write("İlk sayı:  ");
                    int ilksayiii = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İkinci sayı:  ");
                    int ikincisayiii = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem sonucu: " + (ilksayiii * ikincisayiii));
                    break;
                case "4":
                    Console.Write("İlk sayı:  ");
                    int ilksayiiii = Convert.ToInt32(Console.ReadLine());

                    Console.Write("İkinci sayı:  ");
                    int ikincisayiiii = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("İşlem sonucu: " + (ilksayiiii / ikincisayiiii));
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim");
                    break;
            }
            Console.ReadLine();

        }
    }
}
