using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_1
{
    public class Garazas
    {
        
        public List<Automobilis> Sarasas;

        public Garazas()
        {
            Sarasas = new List<Automobilis>();
        }

        public void  Taisyti(List<Automobilis> Sarasas)
        {
            foreach (var tvarkyti in Sarasas)
                if (tvarkyti.Rida >= 10)
                {
                    tvarkyti.Rida *= 0;
                    Console.WriteLine("Sutvarkyta: {0} Rida: {1}", tvarkyti.Modelis, tvarkyti.Rida);                   
                }            

                 Console.ReadLine();               
        }
       
    }
}
