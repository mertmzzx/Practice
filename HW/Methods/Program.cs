namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 7;

            Console.WriteLine(PrimeNumber(number));
        }

        public static int SumDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;

                number /= 10;
            }

            return sum;
        }

        public static int Reverse(int number)
        {
            string reversedNumber = number.ToString();
            reversedNumber.Reverse();

            int result = int.Parse(reversedNumber);

            return result;
        }

        public static int EvenDigits(int number)
        {
            int count = 0;
            while (number > 0)
            {
                int currDigit = number % 10;
                if (currDigit % 2 == 0)
                {
                    count++;
                }

                number /= 10;
            }

            return count;
        }

        public static int ZeroDigits(int number)
        {
            int count = 0;
            while(number > 0)
            {
                int currDigit = number % 10;
                if (currDigit == 0)
                {
                    count++;
                }

                number /= 10;
            }

            return count;
        }

        public static int ProdDigits(int number)
        {
            int prod = 0;

            while (number > 0)
            {
                prod += number % 10;

                number /= 10;
            }

            return prod;
        }

        public static bool PrimeNumber(int number)
        {
            bool prime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}