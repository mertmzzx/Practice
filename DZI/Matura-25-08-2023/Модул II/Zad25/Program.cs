namespace Zad25
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 1 || num > 10000000)
                {
                    throw new Exception();
                }

                int reversedNum = ReverseNumber(num);

                if (num == reversedNum)
                {
                    Console.WriteLine($"{num} is a palindrome");
                }
                else
                {
                    Console.WriteLine($"{num} is NOT a palindrome");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrectly entered number!");
            }
        }

        public static int ReverseNumber(int number)
        {
            int reversedNumber = 0;
            while (number > 0)
            {
                reversedNumber = (reversedNumber * 10) + (number % 10);
                number = number / 10;
            }
            return reversedNumber;
        }
    }
}