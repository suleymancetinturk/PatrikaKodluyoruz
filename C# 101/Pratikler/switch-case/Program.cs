﻿using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayı");
                    break;
                case 2:
                    Console.WriteLine("şubat ayı");
                    break;
                case 5:
                    Console.WriteLine("Mayıs Ayı");
                    break;
                case 4:
                    Console.WriteLine("nisan ayı");
                    break;
                default:
                    Console.WriteLine("hata");
                    break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar Mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimi");
                    break;
                default:
                    break;
            }
        }
    }
}
