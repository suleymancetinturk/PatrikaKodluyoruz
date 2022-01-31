using System;

namespace while_for_each
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            // 1den başlayarak consoledan girilen sayıya kadar (sayı dahil ) ortalama hesaplayıp console a yazdıran program.
            Console.WriteLine("Lütfen Bir sayı Giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // 'a' dan 'z'^ye kadar olan tüm harfleri Console a Yazdırın..
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("***Foreach***");
            string[] arabalar = { "BMW", "FORD", "TOYOTA", "NİSSAN" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba + " ");
            }


        }
    }
}
