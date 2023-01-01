internal class Program
{
    private static void Main(string[] args)
    {
        /*void geriye değer döndürmeyen metotlar örnekleri*/
        yazdır(); /* yazdırmetodu çağır ve yazdır*/
        yazıbosluk();
        yazdır();
        yazıbosluk(); /*yazıboslukmetodunu çağırdı*/
        
        toplamametodu(); /*toplamametodunu çağırdı ve yazdırdı*/
        yazıbosluk();
        
        ardisikSayilar();


        /*Geriye değer döndürmeyen metotlarda parametre kullanma örnekleri*/
        MetinYaz("Merhaba Turkcell Dersleri"); /*parametreli metod çağrıldı*/

        Console.WriteLine("Kelimeyi giriniz: ");
        string kelime = Console.ReadLine();
        MetinYaz2(kelime);


        /*Geriye değer döndüren metotlar örnek*/
        Console.WriteLine("Toplam işlemi sonucu : "+toplama());

        /*Parametreli geriye değer döndüren metotlar örnek */
        Console.WriteLine("Cikarma işlemi sonucu :", cikarma(35, 14));

        /* kullanıcı girişli */
        int sayi1, sayi2;
        Console.Write("1.sayıyı giriniz: ");
        sayi1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("2.sayıyı giriniz: ");
        sayi2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Sonuç: "+cikarma(sayi1,sayi2));
        Console.WriteLine(cikarma(5,4));


        /*Overloading Metotlarda Aşırı yüklenme*/
        Console.WriteLine("Çarpım : " + carpim(50, 85)); /*1.metot parametreler ile*/
        Console.WriteLine("Çarpım : " + carpim(50, 85,75)); /*2.metot parametreler ile */
    }

    /*void geriye değer döndürmeyen metot*/
    public static void yazdır() 
    {
        Console.Write("Bu bir metottur.");
        Console.WriteLine();
        Console.Write("Burası metodun bir başka satırıdır.");
        Console.WriteLine();
    }

    public static void toplamametodu()
    {
        int sayi1 = 24, sayi2 = 30;
        int toplam = sayi1 + sayi2;
        Console.WriteLine(toplam);
    }
    public static void yazıbosluk()
    {
        Console.WriteLine();
        Console.WriteLine("*******");
        Console.WriteLine();
    }
    public static void ardisikSayilar()
    {
        for (int i = 0; i<=10; i++)
        {
            Console.WriteLine(i+ "*****");
        }
    }



    /*Geriye değer döndürmeyen metotlarda parametre kullanma*/
    public static void MetinYaz(string p)
    {
        Console.WriteLine("**********");
        Console.WriteLine();
        Console.WriteLine(p); /*parametreyi yazdırır.*/
        Console.WriteLine();
        Console.WriteLine("************");
    }

    public static void MetinYaz2(string parametre)
    {
        Console.WriteLine("---------");
        Console.WriteLine();
        Console.Write("-----");
        Console.WriteLine(parametre); /*parameteyi yazdırır.*/

    }


    /*Geriye değer döndüren metotlar*/

    public static int toplama()
    {
        int sayi1, sayi2, sonuc;
        sayi1 = 25;
        sayi2 = 35;
        sonuc = sayi1 + sayi2;

        return sonuc; /*sonuc değerini döndür*/
    }
    
    /*  Geriye değer döndüren parametreli metotlar */

    public static int cikarma(int s1,int s2)
    {
        int  sonuc;
        sonuc = s1 - s2; /*parametrelerden gelen değerleri cikarir*/

        return sonuc;
    }

    /*Overloading Metotlarda Aşırı yüklenme*/
    public static int carpim(int s1,int s2)
    {
        int sonuc = (s1 * s2);
        return sonuc;
    }

    public static int carpim(int s1, int s2,int s3)
    {
        int sonuc = (s1 * s2*s3);
        return sonuc;
    }

}