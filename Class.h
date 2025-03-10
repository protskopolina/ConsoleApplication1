namespace ConsoleApp11
{


    static void Main
    {

            StreamReader f1 = new StreamReader("input.txt");
            StreamWriter f = new StreamWriter("output.txt");

            f.WriteLine("\nРозрахунок дозаправки\n");


            int fuelCapacity = Convert.ToInt32(f1.ReadLine()); // Ємність бака
            int distanceAB = Convert.ToInt32(f1.ReadLine());   // Відстань A -> B
            int distanceBC = Convert.ToInt32(f1.ReadLine());   // Відстань B -> C
            int cargoW = Convert.ToInt32(f1.ReadLine());  // Вага вантажу

            int fuelPerKm = cargoW <= 500 ? 1 :
                            cargoW <= 1000 ? 4 :
                            cargoW <= 1500 ? 7 :
                            cargoW <= 2000 ? 9 : -1;


            int fuelRequiredAB = distanceAB * fuelPerKm;
            int fuelRequiredBC = distanceBC * fuelPerKm;

            // Перевірка, чи вистачить палива для подолання відстані A -> B
            if (fuelRequiredAB > fuelCapacity)
            {
                f.WriteLine("Літак не може подолати відстань A -> B.");

                // Після подолання A -> B залишок палива
                int fuelLeftAtB = fuelCapacity - fuelRequiredAB;

                // Перевірка, чи вистачить палива для B -> C
                if (fuelLeftAtB + fuelCapacity < fuelRequiredBC)
                {
                    f.WriteLine("Літак не може подолати відстань B -> C.");

                    int reNeeded = Math.Max(0, fuelRequiredBC - fuelLeftAtB);
                    f.WriteLine("Мінімальна кількість палива для дозаправки в B: {0} літрів.");


                    f.Close();
                    f1.Close();
                }
            }
    }

}




