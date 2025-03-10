namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; // = 3;
            float c;// = 4.0f;
            double f; // = 1.077;
            bool l; // = false;
            string name; // "Petrenko";
            Console.WriteLine("input Призвіще");
            name = Console.ReadLine();
            Console.WriteLine("input a(integer)");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input c(float)");
            c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("input f(double)");
            f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input l(boll");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\nРезультати обчислення функції y = ln(x-1)*cos^2(x):");
            for (int i = 0; i < кількістьТочок; i++)
            {
                double x = xmin + i * крок;
                if (x > 1) // Функція визначена, коли x > 1
                {
                    double y = Math.Log(x - 1) * Math.Pow(Math.Cos(x), 2);
                    Console.WriteLine("x = {0,6:F2}, y = {1,8:F3}", x, y);
                }
                else
                {
                    Console.WriteLine("x = {0,6:F2}, y = Undefined", x);
                    Console.WriteLine("Результати форматування\nname = {0,6}, l ={ 1,4}", name, l);
            Console.WriteLine("a ={0,4}, c ={1,7:f3} , i={2,8:e3}", a, c, f);
            Console.WriteLine("");
            Console.WriteLine("Для виходу натисніть Enter ");
            Console.ReadKey();
        }
    }
}

