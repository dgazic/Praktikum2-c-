using System;
using System.Collections.Generic;


namespace mini_projekt1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool izlaz = true;
            int izbor = 0;
            List<Radnik> radnici = new List<Radnik>();

            do
            {
                Console.WriteLine("---*******************---");
                Console.WriteLine("Izbornik:\n 0: Dodaj odjeljenje\n 1: Dodaj radnika\n 2: Ispiši detaljnije podatke o radnicima\n 3: Ispiši prosječnu plaću radnika\n 4: Izlaz");
                try
                {
                    izbor = Convert.ToInt16(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (izbor)
                {
                    case 0:
                    {
                            Console.WriteLine("Napravi odijel");
                            Odijel o = new Odijel(1, "Development", radnici);
                            o.GetOdijel();
                            break;
                    }
                    case 1: 
                    {
                            Console.WriteLine("Dodaj radnika: ");
                            Radnik r = new Radnik();
                            radnici.Add(r);


                            break;
                    }
                    
                    case 2:
                    {
                            Console.WriteLine("Ispisi informacije o radnicima: ");

                            foreach (var item in radnici)
                            {
                                item.GetRadnik();

                            }
                            break;
                    }

                    case 3: 
                    {

                            Radnik r2 = new Radnik(1);
                            r2.Avg(radnici);
                            break;
                    }

                    case 4:
                    
                    {
                        izlaz = false;
                        break;
                    }
                    
                    default:
                        Console.WriteLine("Neispravan unos, molim ponovite naredbu!(0,1,2,3,4)");
                        break;
                }

            } while (izlaz);
        }
    }
}

