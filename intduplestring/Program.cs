﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intduplestring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToplamaIslem ti = new ToplamaIslem();
            Console.WriteLine(ti.Topla(2, 5));
            Console.WriteLine("==============================");
            Console.WriteLine(ti.Topla(3.3, 5.1));
            Console.WriteLine("==============================");
            Console.WriteLine(ti.Topla("Sağlıcakla ", "kalınız."));
            Console.WriteLine("==============================");
            Console.WriteLine(ti.Topla(3, 8, 3, 7, 12, 33, 11, 4));

        }
    }
    class ToplamaIslem
    {
        public int Topla(params int[] sayilar)
        {
            Console.WriteLine("params parametreli metot çağrılıyor.");
            int toplam = 0;
            foreach (var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
        public double Topla(double a, double b)
        {
            Console.WriteLine("double parametreli metot çağrılıyor.");
            return a + b;
        }
        public string Topla(string a, string b)
        {
            Console.WriteLine("string parametreli metot çağrılıyor.");
            return a + b;
        }
    }
}
    
