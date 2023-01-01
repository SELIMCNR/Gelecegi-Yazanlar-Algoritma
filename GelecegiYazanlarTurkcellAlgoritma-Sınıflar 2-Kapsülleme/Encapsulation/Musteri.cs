using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Musteri
    {
        private int ıd;
        private string name;
        public string surname;
        public string city;


        /*Kapsülleme get değeri getirir , 
         Set değeri clasa götürür ve değişiklikler yaptırır.*/
        public int Id { get => ıd; set => ıd = value; }
        public string Name { get => name; set => name = value.ToLower(); }
        public string Surname
        {
            get => surname;
            set => surname = value.ToUpper(); 
        }
        public string City
        {
            get => city; 
            set => city = value;
        }
    
    }
}
