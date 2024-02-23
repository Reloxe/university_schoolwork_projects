using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayisallotoprogrami
{
    internal class Program
    {
        static void sayisallotovoidi()
        {
            Random sayi = new Random(); // random ile sayim oluşturuyoruz
            int[] rastgele = new int[6];
            for (int i = 0; i < 6; i++)
            {
                rastgele[i] = sayi.Next(1, 50);   // 6 kere 1 ile 49 arasında rastgele sayı oluşturup arraya atıyoruz
            }
            //Numaraları sıralıyoruz
            Array.Sort(rastgele);
            Console.WriteLine("---- 1-49 arasındaki rastgele 6 sayı ----");
            Console.WriteLine(" ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(rastgele[i] + " - ");
            }
            Console.WriteLine("");
            Console.WriteLine(" ");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            sayisallotovoidi();

        }
    }
}
