using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇokBiçimlilik
{
    internal class kuslar
    {
        public string tur;
        public string ses;
        public int hiz;
        public double agirlik;

        public virtual string sescikar() 
        {
            return "buraya ses gelecek";
        }

    }
}
