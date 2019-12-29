using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string price;
            Console.WriteLine("Kredi başvurusu yapmak istediginiz rakamı giriniz");
            price = Console.ReadLine();
            Decisive decisive = new Decisive();
            IStep lvStep;
            lvStep = decisive.FactoryMethod(Convert.ToInt32(price));
            Console.WriteLine("Yönlendirmeniz: " + lvStep.step());
            Console.ReadKey();
        }
    }
    interface IStep
    {
        string step();
    }
    class EmployeeLv1 : IStep
    {
        public string step()
        {
            return "1TL ile 999TL arası kredi için personel ile görüşme saglamalısınız";
        }
    }
    class EmployeeLv2 : IStep
    {
        public string step()
        {
            return "1000TL ile 5000TL Kredi için Müdür yardımcısı ile görüşme sağlamalısınız";
        }
    }
    class EmployeeLv3 : IStep
    {
        public string step()
        {
            return "5000TL üstü kredi için Müdür ile görüşme sağlamalısınız";
        }
    }
    class DefaultStep : IStep
    {
        public string step()
        {
            return "Bu kadar büyük rakamlara kredi veremiyoruz";
        }
    }
    class Decisive
    {
        public IStep FactoryMethod(int lv)
        {
            if (lv >= 1 && lv <= 999)
            {
                return new EmployeeLv1();
            }
            else if (lv >= 1000 && lv <= 5000)
            {
                return new EmployeeLv2();
            }
            else if (lv >= 5001 && lv <= 50000)
            {
                return new EmployeeLv3();
            }
            else
            {
                return new DefaultStep();
            }
            
        }
    }
}
