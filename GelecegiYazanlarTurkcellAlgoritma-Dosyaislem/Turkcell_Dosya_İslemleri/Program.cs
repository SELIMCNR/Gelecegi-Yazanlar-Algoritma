using System;
using System.IO; // System.Io kütühanesi eklendi

namespace Turkcell_Dosya_İslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Metin belgesi oluşturma*/
            /*StreamWriter(içerisine oluşturulacak dosya adresi yazılır.)
             (adresler \\ işareti ile yazılır yad başına @ "dosyyolu" diye yazılır.)
             */
            /*
            StreamWriter sw = new StreamWriter("C:\\Users\\SelimCinar\\Desktop\\deneme.txt");


            /*Metin belgesi içerisine yazı yazma*/
            /*
            sw.Write("Bu bir metin belgesidir. Gelecek teknolojide.");
            sw.Close();

            /*Metin belgesi için klavyeden kod girişi */
            /*
            StreamWriter sw1 = new StreamWriter(@"C:\Users\SelimCinar\Desktop\deneme2.txt");
            string metin;
            Console.WriteLine("Metni giriniz");
           // metin = Console.ReadLine();
           // sw1.Write(metin);
            sw1.Close();
            */
            /*Metin belgesinde veriyi metni okutma*/
            FileStream fs = new FileStream(@"C:\\Users\\SelimCinar\\Desktop\\deneme2.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string metin1 = sr.ReadLine();
            while (metin1 != null)
            {
                Console.WriteLine(metin1);
                metin1 = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            Console.Read();

        }
    }
}
