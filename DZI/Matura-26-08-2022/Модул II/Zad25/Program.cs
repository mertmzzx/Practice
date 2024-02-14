namespace Zad25._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());

                double x = Math.Sqrt(b / (double)a);

                if (a > 0 && b > 0)
                {
                    Console.WriteLine($"Решенията са (-{x:f2}; {x:f2})");
                }
                else if (a < 0 && b < 0)
                {
                    Console.WriteLine($"Решенията са (-inf; -{x:f2}) U ({x:f2}; +inf)");
                }
                else if (a < 0 && b > 0 || a == 0 && b > 0)
                {
                    Console.WriteLine("Всички реални числа са решения");
                }
                else
                {
                    Console.WriteLine("Няма реални решения");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Невалидни входни данни!");
            }
        }
    }
}