﻿namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {



        
            static void Main(string[] args)
            {
                StreamReader f1 = new StreamReader("C:\\Users\\ТвійКористувач\\input.txt");
                StreamWriter f = new StreamWriter("C:\\Users\\ТвійКористувач\\output.txt");
                f.WriteLine("\nРозрахунок до заправки\n");
            metka:
                string? s;
                if ((s = f1.ReadLine()) == null) ;
                int fuelCapasity = Convert.ToInt32(s);
                if ((s = f1.ReadLine()) == null) ;
                int distanceAB = Convert.ToInt32(s);
                if ((s = f1.ReadLine()) == null) ;
                int distanceBC = Convert.ToInt32(s);
                if ((s = f1.ReadLine()) == null) ;
                int cargoW = Convert.ToInt32(s);
                goto metka;
                int fuelPerKm = cargoW <= 500 ? 1 : cargoW <= 1000 ? 4 :
                                 cargoW <= 1500 ? 7 : cargoW <= 2000 ? 9 : -1;
                if (fuelPerKm == -1)
                {
                    f.WriteLine("Літак не може підняти такий вантаж.");
                }
                int fuelRequiredAB = distanceAB * fuelPerKm, fuelRequiredBC = distanceBC * fuelPerKm;
                int fuelLefAtB = fuelCapasity - fuelRequiredAB;
                if (fuelRequiredAB > fuelCapasity)
                    f.WriteLine("Літак не може подолати відстань А->B.");
                else if (fuelRequiredAB + fuelCapasity < fuelRequiredBC)
                    f.WriteLine("Літак не може подолати відстань B->C.");
                else
                    f.WriteLine("мінімальна дозаправка в В:{0} л.", Math.Max(0, fuelRequiredBC - fuelLefAtB));
                goto metka;
                f.Close();
                f1.Close();
            }
        }
    }

}
   