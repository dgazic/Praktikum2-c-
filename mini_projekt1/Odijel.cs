using System;
using System.Collections.Generic;

namespace mini_projekt1
{
    public class Odijel
    {
        private int MaticniBroj { get; set; }
        private string NazivOdijela { get; set; }
        public List<Radnik> Radnici { get; set; }

        public Odijel(int maticniBroj, string nazivOdijela, List<Radnik> radnici)
        {
            this.MaticniBroj = maticniBroj;
            this.NazivOdijela = nazivOdijela;
            Radnici = radnici;
        }



        public void GetOdijel()
        {
            Console.WriteLine(MaticniBroj);
            Console.WriteLine(NazivOdijela);

            foreach (var item in Radnici)
            {
                item.GetRadnik();

            }
        }

    }
}
