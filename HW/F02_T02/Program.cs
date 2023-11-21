namespace F02_T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();

            double n = double.Parse(Console.ReadLine());

            while (n != 0)
            {
                numbers.Add(n);

                n = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Max: {numbers.Max()}");
            Console.WriteLine($"Min: {numbers.Min()}");
        }
    }
}