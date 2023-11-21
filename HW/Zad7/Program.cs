namespace Zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] oddCount = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int countOdd = 0;

                while (n > 0)
                {
                    int remaining = n % 10;

                    if (remaining % 2 != 0)
                    {
                        countOdd++;
                    }
                    n /= 10;
                }

                oddCount[i] = countOdd;
            }

            Console.WriteLine(string.Join(Environment.NewLine ,oddCount));
        }
    }
}