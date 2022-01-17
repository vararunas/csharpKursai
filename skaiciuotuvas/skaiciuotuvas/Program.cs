using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skaiciuotuvas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pasirinkimas();
            Console.Read();
        }

        public static void Pasirinkimas()
        {
            double iSkaicius;
            double iSkaicius2;

            Console.WriteLine("Iveskite pirma skaiciu:");
            iSkaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            iSkaicius2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ka norite daryti? (Iveskite simboli: - + * /)");
            string iPasirinkimas = Console.ReadLine();

            switch (iPasirinkimas)
            {
                case "-":
                    double rezas = iSkaicius - iSkaicius2;
                    Console.WriteLine($"Atimtis: {iSkaicius} - {iSkaicius2} = {rezas}");
                    ArDar();
                    break;

                case "+":
                    double rezas1 = iSkaicius + iSkaicius2;
                    Console.WriteLine($"Sudetis: {iSkaicius} + {iSkaicius2} = {rezas1}");
                    ArDar();
                    break;

                case "*":
                    double rezas2 = iSkaicius * iSkaicius2;
                    Console.WriteLine($"Daugyba: {iSkaicius} * {iSkaicius2} = {rezas2}");
                    ArDar();
                    break;

                case "/":
                    double rezas3 = iSkaicius / iSkaicius2;
                    Console.WriteLine($"dalyba: {iSkaicius} / {iSkaicius2} = {rezas3}");
                    ArDar();
                    break;

                default:
                    Console.WriteLine("Jusu pasirinkias nera aiskus");
                    ArDar();
                    break;
            }
        } // Skaiciu ivestis ir pasirinkimo priskyrimas

        public static void ArDar()
        {
            Console.WriteLine();
            Console.WriteLine("Ar norite dar karta skaiciuoti? Taip/Ne");
            string TaipNe;
            TaipNe = Console.ReadLine().ToUpper();
            if (TaipNe == "TAIP")
            {
                Pasirinkimas();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Aciu kad naudojates skaiciuotuvu, iki pasimatymo !");
                {
                    Console.ReadKey();
                }
            }
        }// grazina i pradziai jei dar nori skaiciuoti
    }
}
