using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //ekrana girilen sayıya kadar olan tek sayıkarı ekrana yazdır.
            Console.WriteLine("Lütfen Bir Sayı Giriniz...");

            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                //komutlar
                if (i % 2 == 1)
                    Console.WriteLine(i);


            }
            //1-1000 arasındaki sayıların  tek ve çift sayıların toplamını console yazınız..
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 1; i <= 1000; i++)
            {

                if (i % 2 == 1)
                    tektoplam += i;
                else
                    cifttoplam += i;

            }
            Console.WriteLine("Tek Toplam : " + tektoplam);
            Console.WriteLine("Çift Toplam : " + cifttoplam);
            int sonuc = tektoplam + cifttoplam;
            Console.WriteLine("Tek Ve Çift Sayıların Toplamı : " + sonuc);

            //break ,Continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);

            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);

            }
            
        }
    }
}
