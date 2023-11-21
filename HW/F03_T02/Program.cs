namespace F03_T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                int remain = 0;
                int sum = 0;

                while (number > 0)
                {
                    remain = number % 10;
                    sum += remain;
                    number /= 10;
                }

                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Avg: {(double)sum / 8}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}