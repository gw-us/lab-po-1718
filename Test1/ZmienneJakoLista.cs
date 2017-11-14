using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class ZmienneJakoLista
    {
        public List<double> ListaZmiennych { get; set; }
        public ZmienneJakoLista()
        {
            ListaZmiennych = new List<double>();
        }
        public double Suma()
        {
            double suma = 0;
            foreach (double elListy in ListaZmiennych)
            {
                suma = suma + elListy;
            }
            return suma;
        }

        public double? Srednia()
        {
            double? srednia = null;
            if (ListaZmiennych.Count > 0)
                srednia = Suma() / ListaZmiennych.Count;
            return srednia;
        }
        public double? Min()
        {
            double? min = null;
            if (ListaZmiennych.Count > 0)
            {
                foreach (double elListy in ListaZmiennych)
                {
                    if (min == null)
                        min = elListy;
                    else
                    {
                        if (elListy < min)
                            min = elListy;
                    }
                }
            }
            return min;
        }
        public double? Max()
        {
            double? max = null;
            if (ListaZmiennych.Count > 0)
            {
                foreach (double elListy in ListaZmiennych)
                {
                    if (max == null)
                        max = elListy;
                    else
                    {
                        if (elListy > max)
                            max = elListy;
                    }
                }
            }
            return max;
        }
    }
}
