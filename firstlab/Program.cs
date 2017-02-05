using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstlab
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string[] f = a.Split();

            foreach( string i in f)
            {
                int n = 0;
                for (int k = 1; k <= int.Parse(i); k++)
                {
                    if (int.Parse(i) % k == 0)
                    {
                    n++;
                    }
                }
            if (n == 2)
                Console.WriteLine(i);
            }
        Console.ReadKey();
        }
    }
}
