using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Zmienne
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double Suma()
        {
            return A + B + C + D;
        }
        public double Srednia()
        {
            return Suma()/4;
        }
        public double Min()
        {
            double min = A;
            if (B < min)
                min = B;
            else
            {
                if (C < min)
                    min = C;
                else
                {
                    if (D < min)
                        min = D;
                }
            }
            return min;
        }
        public double Max()
        {
            double max = A;
            if (B > max)
                max = B;
            else
            {
                if (C > max)
                    max = C;
                else
                {
                    if (D > max)
                        max = D;
                }
            }
            return max;
        }
    }
}
