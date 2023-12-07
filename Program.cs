using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU
{
    class Program
    {
        public class Strom
        {
            public static double VyrastieZaRok=1;
            public static double ZhrubneZaRok = 0.1;
            public double Vyska, Priemer, Vek;
            public void narastie(int roky)
            {
                for (int i=0; i<roky; i++)
                {
                    Vyska=Vyska + VyrastieZaRok;
                    Priemer = ZhrubneZaRok + Priemer;
                    Vek++;
                }
            }
            public void vypis()
            {
                Console.WriteLine("Strom za {0} rokov narastie o {1} m a zhurbne o {2} m.",Vek,ZhrubneZaRok,VyrastieZaRok);
            }
        }
        static void Main(string[] args)
        {
            int a = 5;
            Strom strom = new Strom();          
            strom.narastie(a);
            strom.vypis();
            Console.ReadLine();
        }
    }
}
