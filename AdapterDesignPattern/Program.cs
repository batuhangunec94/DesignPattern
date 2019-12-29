using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Uyarlama birinciAdaptor = new Uyarlama();
            Console.WriteLine(birinciAdaptor.SpesifikIstek(25,32));

            IIslem ikinciAdaptor = new Adaptor();
            Console.WriteLine(ikinciAdaptor.Istek(48));

            Console.ReadKey();
        }
    }
    class Uyarlama
    {
        public double SpesifikIstek(double a, double b)
        {
            return a + b;
        }
    }
    interface IIslem
    {
        string Istek(int i);
    }
    class Adaptor : Uyarlama, IIslem
    {
        public string Istek(int i)
        {
            return "Spesifik İşlem " + (int)Math.Round(SpesifikIstek(i,3));
        }
    }
}
