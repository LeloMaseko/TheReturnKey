using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheReturnKey
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(cube(5));

            cube(5);

            Console.ReadLine();

            int cube(int num)
            {
                int results = num * num * num;
                return results;
            }
        }
    }
}
