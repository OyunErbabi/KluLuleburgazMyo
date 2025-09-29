using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_4
{
    internal class Class1
    {
        int Sayi;
        public void SayiBelirle(int sayi)
        {
            if (sayi < 0)
            {
                Sayi = 0;
            }
            else
            {
                Sayi = sayi;
            }
        }

        public int SayiAl()
        {
            if(Sayi > 100)
            {
                return Sayi /100;
            }
            else
            {
                return Sayi;
            }
        }

    }
}
