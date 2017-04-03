using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Guys, this is a conflict test!");
            Console.WriteLine("Branching is fun yo");

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("i: {0}", i);
            }
            for(int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}
