namespace Zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int h = int.Parse(Console.ReadLine());

            double S1 = Area1(a, h);
            double S2 = Area2(a, b, c);

            Console.WriteLine($"Лицето намерено чрез първия метод е = {S1}");
            Console.WriteLine($"Лицето намерено чрез първия метод е = {S2}");
        }

        static double Area1 (int a, int h)
        {
            return (a * h) / 2;
        }

        static int Area2 (int a, int b, int c)
        {
            return 0;
        }
    }
}