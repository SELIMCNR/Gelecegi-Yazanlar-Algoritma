using Sınıflar_Turkcell;

internal class Program
{
    private static void Main(string[] args)
    {
        
        /*Araba sınıfı */
        
        Araba ar = new Araba();
        ar.marka = "Marka x";
        ar.hiz = 180;
        ar.model = "2021 ";
        ar.motor = 1.6;
        ar.renk = "Beyaz";

        Console.WriteLine("********Araba Tanıtım Kart1 ****");
        Console.WriteLine();
        Console.WriteLine("Marka  : "+ ar.marka);
        Console.WriteLine("Hız    : "+ar.hiz);
        Console.WriteLine("Model  :" + ar.model);
        Console.WriteLine("Motor  :" + ar.motor);
        Console.WriteLine("Renk   :"+ar.renk);


        /*Müşteri Sınıfı*/
        Musteri m = new Musteri();
        m.ad = "Selim";
        m.soyad = "Çınar";
        m.ıd = 1;
        m.sehir = "Kahramanmaraş";

        Console.WriteLine("*********Müşteri Bilgisi **********");
        Console.WriteLine();
        Console.Write( m.ıd + "Ad soyad: "+m.ad + " " + m.soyad + " " + m.sehir + 
            "" );
        Console.WriteLine();
        Console.WriteLine();
        
        m.ıd = 2;
        m.ad = "Yusuf can";
        m.soyad = "Çınar";
        m.sehir = "İstanbul";
        Console.Write(m.ıd + "Ad soyad: " + m.ad + " " + m.soyad + " " + m.sehir +
        "");



        /*Klavyeden değer girişi sınıflarda */
        Console.WriteLine("Id değerini giriniz : ");
        m.ıd =  Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Adınızı :");
        m.ad = Console.ReadLine();

        Console.WriteLine("Soyadınız : ");
        m.soyad = Console.ReadLine();

        Console.WriteLine("Sehriniz : ");
        m.sehir = Console.ReadLine();


        Console.WriteLine("***** Müşteri Kimlik ikinci kart");
        Console.WriteLine();
        Console.WriteLine(m.ıd  + " " + m.ad + "" + m.soyad);
    }
}