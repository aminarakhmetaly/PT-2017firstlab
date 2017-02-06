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
            string a = Console.ReadLine();//reading from the console
            string[] f = a.Split();//spliting an array of strings into parts

            foreach( string i in f)
            {
                int n = 0;
                int p = int.Parse(i);
                for (int k = 1; k <= Math.Sqrt(p); k++)//going till the root of given numbers
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
