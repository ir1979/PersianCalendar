using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate A = new MyDate(1400, 2, 25);
            MyDate B = A + 1;

            Console.WriteLine(B);

            Console.WriteLine(B - A + 1);

            Console.ReadKey();

        }
    }
}
