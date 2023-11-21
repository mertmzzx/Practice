namespace F02_T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double prod = 1;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                sum += number;
                prod *= number;
            }

            Console.WriteLine($"Сумата на всички числа е = {sum}");
            Console.WriteLine($"Произведението на всички числа е = {prod}");
        }
    }
}