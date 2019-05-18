using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            NewClass _class1 = NewClass.getInstance();
            NewClass _class2 = NewClass.getInstance();


            Console.WriteLine(_class1.GetHashCode());
            Console.WriteLine(_class2.GetHashCode());

            Console.ReadKey();
        }
    }
}
