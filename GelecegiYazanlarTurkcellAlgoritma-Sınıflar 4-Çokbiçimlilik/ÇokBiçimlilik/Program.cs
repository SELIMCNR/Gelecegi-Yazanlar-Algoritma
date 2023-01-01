using System;

namespace ÇokBiçimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            papagan p = new papagan();
            p.sescikar();

            Console.WriteLine("Ses: "+ p.sescikar());
            Console.WriteLine();
            Console.WriteLine();

            karga k = new karga();
            k.agirlik = 1350;
            k.hiz = 80;
            k.isim = "Alacakarga";
            k.renk = "Siyah";
            k.tur = "Karga";
            k.sescikar();

            Console.WriteLine("Ağırlık "+ k.agirlik);
            Console.WriteLine("Hız:  "+k.hiz);
            Console.WriteLine("İsim: "+k.isim);
            Console.WriteLine("Renk: "+k.renk);
            Console.WriteLine("Hız:  "+k.tur);
            Console.WriteLine("Tür:  "+k.sescikar());



        }
    }
}
