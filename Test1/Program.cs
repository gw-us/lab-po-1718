using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

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
            //lab2017_11_13();
            //lab2017_11_14();
            //lab2017_11_14_lista();
            lab2017_11_14_gielda();

            Console.ReadKey();
        }

        static void lab2017_11_14_gielda()
        {
            List<Notowanie> listaNotowan = new List<Notowanie>();
            var csv = new CsvReader(File.OpenText(@"Pliki\11BIT.mst"));
            csv.Configuration.CultureInfo = new System.Globalization.CultureInfo("en");
            var _11bit = csv.GetRecords<Notowanie>();
            foreach (Notowanie not in _11bit)
            {
                Console.WriteLine("Spółka: " + not.TICKER + " Data: " + not.Date.ToString() + ", Close: " + not.CLOSE);
                listaNotowan.Add(not);
            }
            Console.WriteLine("Liczba notowań: " + listaNotowan.Count);
            listaNotowan.AddRange(Notowanie.PobierzNotowanie(@"Pliki\CDPROJEKT.mst"));
            Console.WriteLine("Liczba notowań: " + listaNotowan.Count);
            listaNotowan.AddRange(Notowanie.PobierzNotowanie(@"Pliki\CIGAMES.mst"));
            Console.WriteLine("Liczba notowań: " + listaNotowan.Count);

            Console.WriteLine("Liczba notowań < 10: " + listaNotowan.Count(p => p.CLOSE < 10 && p.TICKER == "CDPROJEKT"));

            Console.WriteLine("Notowania CDPROJEKT z lipca 2017:");
            var wybraneNotowania = listaNotowan.Where(p=>p.TICKER == "CDPROJEKT" && p.Date.Year == 2017 && p.Date.Month == 7);
            foreach (Notowanie not in wybraneNotowania)
            {
                Console.WriteLine(" Data: " + not.Date.ToString() + ", Close: " + not.CLOSE);
            }
            Console.WriteLine("Średnia CDPROJEKT 2017 lipiec: " + wybraneNotowania.Average(p=> p.CLOSE).ToString());
        }

        static void lab2017_11_14_lista()
        {
            ZmienneJakoLista zm = new ZmienneJakoLista();
            zm.ListaZmiennych.Add(-10);
            zm.ListaZmiennych.Add(-20);
            zm.ListaZmiennych.Add(1);
            zm.ListaZmiennych.Add(-2);
            Console.WriteLine("Liczby w liście: ");
            foreach(double elListy in zm.ListaZmiennych)
                Console.WriteLine(elListy);
            Console.WriteLine("Suma: " + zm.Suma());
            Console.WriteLine("Średnia: " + zm.Srednia());
            Console.WriteLine("Min: " + zm.Min());
            Console.WriteLine("Max: " + zm.Max());

        }
        static void lab2017_11_14()
        {
            Zmienne zm = new Zmienne();
            zm.A = -10;
            zm.B = -20;
            zm.C = 1;
            zm.D = -2;
            Console.WriteLine("A: " + zm.A);
            Console.WriteLine("B: " + zm.B);
            Console.WriteLine("C: " + zm.C);
            Console.WriteLine("D: " + zm.D);
            Console.WriteLine("Suma: " + zm.Suma());
            Console.WriteLine("Średnia: " + zm.Srednia());
            Console.WriteLine("Min: " + zm.Min());
            Console.WriteLine("Max: " + zm.Max());

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
