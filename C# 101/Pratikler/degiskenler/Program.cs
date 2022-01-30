using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            // int deger = 2;
            // string degisken = null;
            // string Degisken = null;
            // string degisken_veri = null;
            byte b = 5;             // 1 byte;
            sbyte c = 5;            // 1 byte;

            short s = 5;            // 2 byte;
            ushort us = 5;          // 2 byte;
            Int16 i16 = 2;          // 2 byte;
            int i = 2;              // 4 byte;
            Int32 i32 = 2;          // 4 byte;
            Int64 i64 = 2;          // 8 byte;
            uint ui = 2;            // 4 byte;
            long l = 4;             // 8 byte;
            ulong ul = 4;           // 8 byte;
            //reel sayılar
            float f = 5;            // 4 byte;
            double d = 5;           // 8 byte;
            decimal de = 5;         // 16 byte;

            char ch = "2";          // 2 byte;
            string str = "man";     // sınırsız;

            bool bl = true;
            bool bl2 = false;
            DateTime dt = DateTime.Now;

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;



            // string ifadeler

            string str1 = string.Empty;
            str1 = "suleyman çetinturk";
            string ad = "süleyman";
            string soyad = "Çeintürk";
            string tamisim = ad + " " + soyad;

            // integer tanımlama şekli

            int i1 = 5;
            int i2 = 10;
            int toplam = i1 * i2;

            // boolen

            bool bol1 = 10 > 2;

            //değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString;

            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32[int20];
            Console.WriteLine(int21);

            int22 = int20 + int.Parse(str20);// çıktısı 40

            // date time
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            

        }
    }
}
