﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HODINA
{
    class Program
    {
        /*public static double objem(double radius, double vyska)
        {

            
            return (((radius * radius) * vyska * Math.PI) / 3);        
        }*/

        static void Main(string[] args)
        {
            /*double x = 0;
            for (int i = 0; i<4; i++)
            {
                Console.WriteLine("napis R");
                double.TryParse(Console.ReadLine(), out double r);
                Console.WriteLine("napis V");
                double.TryParse(Console.ReadLine(), out double v);

                Program.objem(r,v);
                x += Program.objem(r,v);
            }
            Console.WriteLine("celkovy ibjem");
            Console.WriteLine(x);
            Console.ReadLine();*/
            STROM strom= new STROM();
            strom.radius = 10;
            strom.vyska= 10;
            Console.WriteLine(strom.Volume);
            BAOBAB baobab = new BAOBAB();
            baobab.radius = 10;
            baobab.vyska = 10;
            Console.WriteLine(baobab.Volume);



        }
    }
}
