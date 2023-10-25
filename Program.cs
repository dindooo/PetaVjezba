using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaPeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite jedan cijeli i jedan decimalni broj; odvojite ih razmakom");
            string niz = Console.ReadLine();
            string[] a = niz.Split(' ');

            int x = Convert.ToInt32(a[0]);
            float y = Convert.ToSingle(a[1]);

            Console.WriteLine(x * 2);
            Console.WriteLine(y * 2);

            Console.ReadKey();
        }
    }
}
