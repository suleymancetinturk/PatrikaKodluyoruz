using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x += 2;
            Console.WriteLine(x);
            // Mantuksal Operatörler
            // ||,&&,!
            Console.WriteLine("***Mantıksal operatörler***");

            bool isSuccess = true;
            bool iscompleted = false;

            if (isSuccess && iscompleted)
            {
                Console.WriteLine("perfect");

            }
            if (isSuccess || iscompleted)
                Console.WriteLine("Great");


            if (isSuccess && !iscompleted)
                Console.WriteLine("Fine!");

            //ilişkisel operatörler
            // < ,> ,<=,>=,==,!=
            Console.WriteLine("***İlişkisel operatörler***");
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);
            //aritmatik operatörler
            //+,-,*,/
            Console.WriteLine("***Aritmatik Operatörler***");
            int sayi1 = 3;
            int sayi2 = 10;
            int sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            // % :mod alır;
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
