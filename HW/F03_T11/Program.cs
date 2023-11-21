namespace F03_T11
{
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m, pos = 1, sum = 0, prod = 1;
            n = ReverseInt(n) / 10;

            while (n > 0)
            {
                if (pos % 2 == 0)
                {
                    m = n % 10;
                    sum += m;
                    n = n / 10;
                }
                else
                {
                    m = n % 10;
                    prod *= m;
                    n = n / 10;
                }

                pos++;
            }
            Console.WriteLine($"Сумата от цифрите на четни позиции е = {sum}");
            Console.WriteLine($"Произведението от цифрите на нечетни позиции е = {prod}");

        }

        public static int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }
    }
}