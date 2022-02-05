using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_1
{
    public class Automobilis
    {
        public string Modelis { get; set; }
        public int Rida { get; set; }
        public bool GalimaVaziuoti { get; set; }

        public Automobilis(string modelis, int rida, bool galimaVaziuoti)
        {
            Modelis = modelis;
            Rida = rida;
            GalimaVaziuoti = galimaVaziuoti;            
        }

        public Automobilis()
        {
        }

        public void Vaziuoti(List<Automobilis> Sarasas)
        {
            Garazas garazas = new Garazas();    
            foreach (var vaziuoti in Sarasas)
            {
                if (vaziuoti.Rida <= 9)
                {
                    vaziuoti.Rida += 10;
                    Console.WriteLine("Automobilio:{0} Rida buvo prideta:{1}", vaziuoti.Modelis, vaziuoti.Rida);
                }
            }

            foreach (var sugedo in Sarasas)
            {                
                if (sugedo.Rida >= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sugedo(es):{0} Rida: {1}", sugedo.Modelis, sugedo.Rida);
                    Console.ResetColor();
                }
            }

            Console.WriteLine("Tvarkome automobilius Taip/Ne?");
            string taipNe = Console.ReadLine();

            switch(taipNe)
            {
                case "Taip":
                    garazas.Taisyti(Sarasas);                
                break;
                    
                case "Ne":
                    garazas.BandytiVaziuoti(Sarasas);                    
                    break;

                default:
                    break;
            }
        }
    }
}
