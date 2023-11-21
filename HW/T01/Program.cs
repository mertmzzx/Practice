namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 3)
            {
                num *= 10;
            }
            else if (num >= 4 && num <= 6)
            {
                num *= 100;
            }
            else if (num >= 7 && num <= 9)
            {
                num *= 1000;
            }
            else
            {
                Console.WriteLine("Грешка! Точките трябва да бъдат в интервала [1..9]");
                return;
            }

            Console.WriteLine($"Общ брой точки: {num}");
        }
    }
}