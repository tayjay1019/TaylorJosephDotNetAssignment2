using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Billy";
            string address = "123 Pine St";
            var pi = Math.PI;

            Console.WriteLine("Billy");
            Console.WriteLine("{0}", name);
            Console.WriteLine($"{name}");
            Console.WriteLine("|{0}|{1}|", "", "123 Pine St");

            // positive: right aligned
            Console.WriteLine("|{0,-8}|{1,12}|", "Billy", "123 Pine St");

            Console.WriteLine("|{0,8}|{1,2}|", name, address);

            Console.WriteLine($"{pi:n5}");
        }
    }
}
