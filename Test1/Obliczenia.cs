using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Obliczenia
    {
        public double A { get; set; }
        public double B { get; set; }
        public double Dodaj()
        {
            return A + B;
        }
        public double Odejmij()
        {
            return A - B;
        }
        public double Pomnoz()
        {
            return A * B;
        }
        public double Podziel()
        {
            return A / B;
        }

        public Obliczenia()
        {
            A = 1;
            B = 1;
        }

        public Obliczenia(double a, double b)
        {
            A = a;
            B = b;
        }
    }
}
