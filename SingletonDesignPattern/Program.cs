using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonObject = SingletonObject.CreateSingletonObject();
            singletonObject.Save();
        }
    }

    class SingletonObject
    {
        private static SingletonObject _singletonObject;

        public SingletonObject()
        {

        }

        public static SingletonObject CreateSingletonObject()
        {

            if (_singletonObject == null)
            {
                _singletonObject = new SingletonObject();
            }

            return _singletonObject;
        }

        public void Save()
        {
            Console.WriteLine("Saved...!");
            Console.ReadKey();
        }
    }
}
