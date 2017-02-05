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
            string[] f = a.Split();//spliting an array of strings into parts

            foreach( string i in f)
            {
                int n = 0;
                for (int k = 1; k <= int.Parse(i); k++)
                {
                    if (int.Parse(i) % k == 0)//checking whether number is prime or not
                    {
                    n++;
                    }
                }
            if (n == 2)
                Console.WriteLine(i);//taking solution
            }
        Console.ReadKey();
        }
    }
}
