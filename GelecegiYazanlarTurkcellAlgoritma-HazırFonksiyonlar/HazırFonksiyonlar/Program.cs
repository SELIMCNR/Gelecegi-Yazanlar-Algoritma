using System;

namespace HazırFonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Matetmatikse fonksiyonlar 
            double sayi;
            Console.WriteLine("Sayıyı giriniz: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Mutlak değer:" + Math.Abs(sayi)); // Mutlak değer
            Console.WriteLine("Üst taban "+ Math.Ceiling(sayi)); //üst taban                                                      // 
            Console.WriteLine("Alt taban "+ Math.Floor(sayi)); // alt taban 
            Console.WriteLine("Karekök "+Math.Sqrt(sayi));  // karekök hesaplama
            Console.WriteLine("Yuvarlama" + Math.Ceiling(sayi)); /*yuvarlama*/
            Console.WriteLine("pi and üsalma işlemi" + Math.PI*Math.Pow(2,sayi));
            Console.WriteLine();

            //Metinsel fonksiyonlar 
            string metin,metin2;
            Console.WriteLine("Metni giriniz: ");
            metin = Console.ReadLine();
            Console.WriteLine("Metni giriniz: ");
            metin2 = Console.ReadLine();

            Console.WriteLine("Concat ile birleştirme "+string.Concat(metin,metin2));
            Console.WriteLine("Metin 1 için karakter sayısı : "+metin.Length);
            Console.WriteLine("Indexof örneği: "+ metin.IndexOf("aydın")); // index değerini getirir
            Console.WriteLine("Startswith örneği: "+metin.StartsWith("merhaba"));
            Console.WriteLine("     Merhaba Dünya  "+ metin.Trim()); /*Boşlukları siler*/
            Console.WriteLine("Büyük harf :"+metin.ToUpper());
            Console.WriteLine("Küçük harf :"+metin.ToLower());
            Console.WriteLine("Remove metodu: "+metin.Remove(4));  // ilk 3 indexten sonrasını siler 
            Console.WriteLine("Replace fonksiyonu : "+metin.Replace("a","A")); // küçük a'yı büyük a yap
            Console.WriteLine("Substring fonksiyonu: "+metin.Substring(4)); // 4 indexten sonrasını getirir.


            /*Tarih zaman (datetime) fonksiyonları*/
            Console.WriteLine("Bugünün gün bilgisi "+DateTime.Now.Day);
            Console.WriteLine("Bugünün ay bilgisi " + DateTime.Now.Month);
            Console.WriteLine("Bugünün yıl bilgisi " + DateTime.Now.Year);
            Console.WriteLine("Bugünün saat bilgisi " + DateTime.Now.Hour);
            Console.WriteLine("Bugünün dakika bilgisi " + DateTime.Now.Minute);
            Console.WriteLine("Bugünün saniye bilgisi "+DateTime.Now.Second);
            Console.WriteLine("Bugünün kısa tarih bilgisi  " + DateTime.Now.ToShortDateString());
            Console.WriteLine("Bugünün uzun tarih bilgisi  " + DateTime.Now.ToShortDateString());



            /*Time span iki tarih arasında farkı hesaplar*/
            TimeSpan zaman;
            int gunfarki;
            DateTime tarih1, tarih2;
            tarih1 =Convert.ToDateTime("01.01.2020");
            tarih2 = Convert.ToDateTime("15.01.2020");
            zaman = tarih2 - tarih1;
            gunfarki = zaman.Days;
            Console.WriteLine("Fark : " + gunfarki);
            Console.Read();
            Console.ReadLine();

            /*Hayatta kalma tarihi */
            TimeSpan zaman1;
            int gunfarki1;
            DateTime tarih11, tarih22;
            tarih11 = Convert.ToDateTime("27.10.2000");
            tarih22 = Convert.ToDateTime("29.12.2022");
            zaman1 = tarih22 - tarih11;
            gunfarki1 = zaman1.Days;
            Console.WriteLine("Fark : " + gunfarki1);
            Console.Read();
            Console.ReadLine();

        }
    }
}
