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
           
            foreach( string i in args)
            {
                int n = 0;
                int p = int.Parse(i);
                for (int k = 1; k <= (p); k++)
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
