namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0.26, b = 3.7;

            double y = Math.Pow(a + 1, 5) + Math.Exp(b - 1) * 3;

            Console.WriteLine($"{{a,{a:F6}}}, {{b,{b:F6}}}, {{c,{y:F3}}}");
            Console.ReadKey();
        }
    }
}
        
    





