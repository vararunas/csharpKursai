using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarIrDar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bandykite atspeti slapta skaiciu nuo 1 iki 10ties :)");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int spejimas = 8;

            do
            {

                if (skaicius < spejimas)
                {
                    Console.WriteLine("Skaicius yra didesnis, bandykite dar karta");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }
                else if (skaicius > spejimas)
                {
                    Console.WriteLine("Skaicius yra mazesnis, bandykite dar karta");
                    skaicius = Convert.ToInt32(Console.ReadLine());
                }
                
            }
         
            while (skaicius != 8);
            Console.WriteLine("Atspejote!!!");
            Console.ReadKey();
        }

    }
}
