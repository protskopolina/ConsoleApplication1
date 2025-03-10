namespace ConsoleApp11
{


    static void Main
    {

            StreamReader f1 = new StreamReader("input.txt");
            StreamWriter f = new StreamWriter("output.txt");

            f.WriteLine("\n���������� ����������\n");


            int fuelCapacity = Convert.ToInt32(f1.ReadLine()); // ������ ����
            int distanceAB = Convert.ToInt32(f1.ReadLine());   // ³������ A -> B
            int distanceBC = Convert.ToInt32(f1.ReadLine());   // ³������ B -> C
            int cargoW = Convert.ToInt32(f1.ReadLine());  // ���� �������

            int fuelPerKm = cargoW <= 500 ? 1 :
                            cargoW <= 1000 ? 4 :
                            cargoW <= 1500 ? 7 :
                            cargoW <= 2000 ? 9 : -1;


            int fuelRequiredAB = distanceAB * fuelPerKm;
            int fuelRequiredBC = distanceBC * fuelPerKm;

            // ��������, �� ��������� ������ ��� ��������� ������ A -> B
            if (fuelRequiredAB > fuelCapacity)
            {
                f.WriteLine("˳��� �� ���� �������� ������� A -> B.");

                // ϳ��� ��������� A -> B ������� ������
                int fuelLeftAtB = fuelCapacity - fuelRequiredAB;

                // ��������, �� ��������� ������ ��� B -> C
                if (fuelLeftAtB + fuelCapacity < fuelRequiredBC)
                {
                    f.WriteLine("˳��� �� ���� �������� ������� B -> C.");

                    int reNeeded = Math.Max(0, fuelRequiredBC - fuelLeftAtB);
                    f.WriteLine("̳������� ������� ������ ��� ���������� � B: {0} ����.");


                    f.Close();
                    f1.Close();
                }
            }
    }

}




