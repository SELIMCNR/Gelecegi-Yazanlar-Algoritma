using System;

namespace Random_Turkcell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random sınıf uygulaması
            int sayi;
            Random r = new Random();   //sınıfran r adlı obje oluştu
            sayi = r.Next(0,51);   //0,51 aralında objeden sayı değişkenie sayı gönderildi
            Console.WriteLine(sayi);  //ekrana yazdırıldı.
            Console.Read();




            //Random sınıf uygulaması dizilerle
            int sayi1,sayi2;
            Random r1 = new Random();   //sınıfran r adlı obje oluştu
            sayi1 = r1.Next(0, 51);   //0,51 aralında objeden sayı değişkenie sayı gönderildi
            sayi2 = r1.Next(0, 51);
            Console.WriteLine(sayi1 + "" + sayi2);  //ekrana yazdırıldı.
            Console.Read();


            Random rn = new Random();
            int sehir;
            string[] sehirler = { "a", "b", "c", "d" };
            sehir = rn.Next(0, sehirler.Length);  // 0 , ile dizi uzunluğu kadar sayı gelir.
            Console.WriteLine(sehirler[sehir]);
            Console.Read();

            /*Captcha oluşturma*/
            int d1, d2, d3, d4;
            Random rnd = new Random();
            d1 = rnd.Next(0, 10);
            d2 = rnd.Next(0, 10);
            d3= rnd.Next(0, 10);
            d4= rnd.Next(0, 10);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            
            string[] karakterler = { "a", "A","b","B", "c","C", "d","D","e","E" };
            Console.WriteLine(d1 + karakterler[d2] + d3 + karakterler[d4]);
            Console.Read();









        }



    }
}
