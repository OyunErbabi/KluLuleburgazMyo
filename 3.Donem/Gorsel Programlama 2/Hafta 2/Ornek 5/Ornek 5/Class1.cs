using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_5
{
    internal class Class1
    {
        int Sayi;

        public int sahteozellik
        {
            set {
                if (value < 0)
                    Sayi = 0;
                else
                    Sayi = value;
            }
            get { 
                if(Sayi>100)
                    return Sayi/100;
                else
                    return Sayi;
            }
        }


    }
}
