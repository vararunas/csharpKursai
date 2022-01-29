using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Automobilis> Sarasas = new List<Automobilis>();
            Sarasas.Add(new Automobilis( "BMW", 5, true));
            Sarasas.Add(new Automobilis( "AUDI", 15, false));
            Sarasas.Add(new Automobilis( "MB", 10, false));
            Sarasas.Add(new Automobilis( "VOLVO", 2, true));
            Sarasas.Add(new Automobilis( "VW", 7, true));           
            
            foreach (var auto in Sarasas)
            {                
                if (auto.Rida <= 9)
                {
                    Console.WriteLine("Tvarkingas automobilis: {0} rida: {1}", auto.Modelis, auto.Rida);                    
                }               
                else
                {
                    Console.WriteLine("Reikia remonto automobiliui: {0} rida: {1}", auto.Modelis, auto.Rida);
                }                
            }

            Automobilis v = new Automobilis();
            Garazas g = new Garazas(); 

            Console.WriteLine("Vaziuoti ar Taisyti?");
            string vaziuotiTaisyti = Console.ReadLine();

            switch (vaziuotiTaisyti)
            {
                case "Vaziuoti":
                    v.Vaziuoti(Sarasas);
                    Console.WriteLine(); 
                    break;

                case "Taisyti":
                    g.Taisyti(Sarasas);                    
                    break;
                    default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
