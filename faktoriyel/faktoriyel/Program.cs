using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Faktoriyeli alınacak sayıyı giriniz");
                var fakt_sayi = int.Parse(Console.ReadLine());
                var baslangic = 1;
                var ilk_deger = fakt_sayi;
                if (fakt_sayi > 0)
                {
                    while (fakt_sayi > 0)
                    {
                        baslangic *= fakt_sayi;
                        fakt_sayi--;
                    }
                    Console.WriteLine("{0} sayısının faktoriyeli = {1}", ilk_deger, baslangic);
                }
                else
                {
                    Console.WriteLine("Lütfen sıfırdan büyük bir sayı giriniz");
                }
            }
        }

    }
}
