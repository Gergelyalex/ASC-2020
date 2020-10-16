using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mooreslaw
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much greater the computational power ?");
            int i = 1, j = 0, n;
            n = int.Parse(Console.ReadLine());
            while (i < n)
            {
                i = i * 2;
                j = j + 2;

            }
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
