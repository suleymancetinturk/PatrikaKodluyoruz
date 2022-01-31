using System;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Bir Sayı Giriniz..");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz sayi : " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata : " + ex.Message);

            }
            // finally
            // {
            //     Console.WriteLine("işlem tamamlandı");
            // }

            try
            {
                // int a =int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-2000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz....");
                Console.WriteLine(ex);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("veri Tipi Uygun değil....");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("çoook büyük yada çok küçük bir değer girdiniz...");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem başarılı şekilde tamamlandı....");
            }
        }
    }
}
