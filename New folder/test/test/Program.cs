using System;
using System.Collections.Generic;
using System.Linq; //zbog ovoga se nad int[] moze pozvati funkcija Orderby koju implementira IEnumerable<T>
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 10, 45, 15, 39, 21, 26 };
            var result = ints.OrderBy(g => g);
            foreach (var i in result)
            {
                System.Console.Write(i + " ");
            }
            string k = "Muho";
            System.Console.Write(k.fun());
        }
    }
}
