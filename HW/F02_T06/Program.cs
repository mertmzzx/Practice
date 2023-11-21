namespace F02_T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool prime = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("Числото е просто.");
            }
            else
            {
                Console.WriteLine("Числото не е просто.");
            }
            
        }
    }
}