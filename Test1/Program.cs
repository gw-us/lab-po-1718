﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //pierwiastkiRownaniaKwadratowego(10, -2, 2);
            //pierwiastkiRownaniaKwadratowego(2, 1, -2);

            //lab2017_10_17();
            //lab2017_10_30();
            lab2017_11_13();

            Console.ReadKey();
        }
        static void lab2017_11_13()
        {
            Pierwiastki pierw = new Pierwiastki();
            pierw.A = 1;
            pierw.B = -1;
            pierw.C = -10;
            pierw.Wyswietl();
        }

        static void lab2017_10_30()
        {
            //Pętla FOR
            for(int i = 1; i <= 100; i++) 
                Console.WriteLine(i);

            //Pętla WHILE
            int n = 102;
            while (n <= 100)
            {
                Console.WriteLine(n);
                n++;
            }

            //Pętla DO WHILE
            int x = 102;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 100);
        }


        static void lab2017_10_17()
        {
            Obliczenia obl1 = new Obliczenia();
            obl1.A = 10;
            obl1.B = 0;
            Console.WriteLine("A=" + obl1.A);
            Console.WriteLine("B=" + obl1.B);
            Console.WriteLine("Dodawanie=" + obl1.Dodaj());
            Console.WriteLine("Odejmowanie=" + obl1.Odejmij());
            Console.WriteLine("Mnożenie=" + obl1.Pomnoz());
            Console.WriteLine("Dzielenie=" + obl1.Podziel());

            Obliczenia obl2 = new Obliczenia(20, 10);
        }

        static void pierwiastkiRownaniaKwadratowego(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
            }
            else
            {
                if (delta == 0)
                {
                    double x0 = -b / (2 * a);
                    Console.WriteLine("x0=" + x0);
                }
                else
                {
                    Console.WriteLine("Brak rozwiązań");
                }
            }
        }
    }
}