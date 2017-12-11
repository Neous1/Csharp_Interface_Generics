using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    interface IFoo
    {
        void SomeMethod();
    }
    interface IBar
    {
        void SomeMethod();
    }

    class FooBar : IFoo, IBar
    {
        public void SomeMethod()
        {
            Console.WriteLine("This is the class SomeMethod");
        }
    }

    class Program
    {
        static void Main(string[] args) {
            
            Console.ReadLine();
        }
    }
}
