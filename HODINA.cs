using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HODINA
{
    class Program
    {
        public static double objem(double radius, double vyska)
        {
            
            return (((radius * radius) * vyska * Math.PI)/ 3);
        }

        static void Main(string[] args)
        {
            
            
            Console.WriteLine("napis R");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("napis V");
            double.TryParse(Console.ReadLine(), out double b);
            Program.objem(a, b);
            Console.WriteLine(Program.objem(a, b));
            Console.ReadLine() ;
            

        }
    }
}
