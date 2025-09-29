using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_6
{
    internal class Class1
    {
        public Class1()
        {
            Console.WriteLine("Sinif Aktif, Yapici Metot Calisti");            
        }

        ~Class1()
        {
            Console.WriteLine("Sinif Pasif, Yikici Metot Calisti");
            Console.ReadLine();
        }

    }
}
