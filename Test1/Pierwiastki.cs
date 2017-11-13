using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Pierwiastki
    {
        private double a;
        public double A
        {
            get { return a; }
            set
            {
                a = value;
                ObliczPierwiastki();
            }
        }
        private double b;
        public double B { 
            get {
                return b;
            }
            set {
                b = value;
                ObliczPierwiastki();
            }
        }
        private double c;
        public double C { 
            get {
                return c;
            }
            set
            {
                c = value;
                ObliczPierwiastki();
            }
        }
        private double Delta { get; set; }
        private void obliczDelta()
        {
            Delta = B * B - 4 * A * C;
        }
        public double? X1 { get; private set; }
        public double? X2 { get; private set; }

        public void ObliczPierwiastki()
        {
            obliczDelta();
            if (Delta > 0)
            {
                X1 = (-B - Math.Sqrt(Delta)) / (2 * A);
                X2 = (-B + Math.Sqrt(Delta)) / (2 * A);
            }
            else
            {
                if (Delta == 0)
                {
                    X1 = -B / (2 * A);
                    X2 = null;
                }
                else
                {
                    X1 = null;
                    X2 = null;
                }
            }
        }

        public void Wyswietl()
        {
            ObliczPierwiastki();
            if (Delta > 0)
            {
                Console.WriteLine("x1=" + X1);
                Console.WriteLine("x2=" + X2);
            }
            else
            {
                if (Delta == 0)
                {
                    Console.WriteLine("x0=" + X1);
                }
                else
                {
                    Console.WriteLine("Brak rozwiązań");
                }
            }
        }

    }
}
