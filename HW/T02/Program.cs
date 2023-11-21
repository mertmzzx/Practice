namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int reverse = 0;
            while (temp != 0)
            {
                reverse = (reverse * 10) + temp % 10;
                temp /= 10;
            }

            if (number == reverse)
            {
                Console.WriteLine($"{number} - да");
            }
            else
            {
                Console.WriteLine($"{number} - не");
            }
        }
    }
}