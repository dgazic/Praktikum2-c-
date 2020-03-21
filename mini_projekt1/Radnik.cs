using System;
using System.Collections.Generic;

namespace mini_projekt1
{
    public class Radnik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        protected int Placa { get; set; }

        public List<Radnik> Radnici { get; set; }
       

        public void Avg(List<Radnik> radnici)
        {
            Radnici = radnici;
            float suma = 0;
            float brojac = 0;
            foreach (var s in Radnici)
            {
                suma += s.Placa;
                brojac++;

            }

            Console.WriteLine("Prosjecna placa je: " + suma / brojac);


        }

        public Radnik(int a)
        {
            Console.WriteLine("Prosjecna placa");
        }
        public Radnik()
        {
            Console.WriteLine("Ime radnika: ");
            var ime = Console.ReadLine();
            Ime = ime;


            Console.WriteLine("Prezime radnika: ");
            var prezime = Console.ReadLine();
            Prezime = prezime;

            Console.WriteLine("Email radnika: ");
            var email = Console.ReadLine();
            Email = email;

            Console.WriteLine("Unesite placu radnika: ");
            var placa = Console.ReadLine();
            int i = Convert.ToInt16(placa);
            Placa = i;


        }




        public void GetRadnik()
        {
            Console.WriteLine(Ime);
            Console.WriteLine(Prezime);
            Console.WriteLine(Email);
            Console.WriteLine(Placa);

        }
    }

}
