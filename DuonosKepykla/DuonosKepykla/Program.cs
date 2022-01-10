using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuonosKepykla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kiek darbuotojas gali iskepti duonos per valanda?");
            int kepaDuona = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek kepykla turi darbuotoju?");
            int kiekDarbuotoju = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kokia duonos savikaina?");
            double savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Duonos pardavimo kaina?");
            double pardavimoKaina = Convert.ToDouble(Console.ReadLine());

            int darboValandos = 8;

            var duonaPerValanda = kiekDarbuotoju * 1;
            var kepaPerValanda = kiekDarbuotoju * 1;
            var pardavimai = pardavimoKaina + savikaina * kepaDuona;

            Console.WriteLine($"gali iskepti: {duonaPerValanda} \nKepykla turi darbuotoju:{kiekDarbuotoju} \nDuonos savikaina:{savikaina}\nDuonos pardavimo kaina:{pardavimoKaina}");
            Console.WriteLine($"Spes iskpeti:{duonaPerValanda}\nPelnas:{pardavimai}");
            Console.ReadLine();






        }
    }
}
