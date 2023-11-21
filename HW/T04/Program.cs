namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете стойност за xa: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Въведете стойност ya: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Квадрант I");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Квадрант II");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Квадрант III");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Квадрант IV");
            }
        }
    }
}