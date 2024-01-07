using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(double x, double y)
        {
            double toplam = x + y;
            Console.WriteLine("Sonuç: " + toplam);
        }
        public void Cikar(double x, double y)
        {
            double toplam = x - y;
            Console.WriteLine("Sonuç: " + toplam);
        }
        public void Carp(double x, double y)
        {
            double toplam = x * y;
            Console.WriteLine("Sonuç: " + toplam);
        }
        public void Bol(double x, double y)
        {
            if(y > 0)
            {
                double toplam = x / y;
                Console.WriteLine("Sonuç: " + toplam);
            }
            else
            {
                Console.WriteLine("0'dan büyük bir sayı giriniz");
            }
        }
    }
}
