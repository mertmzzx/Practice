namespace F03_T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N = ");
                double N = double.Parse(Console.ReadLine());
                Console.Write("M = ");
                double M = double.Parse(Console.ReadLine());

                double x = (M * N) / (M + N);

                Console.WriteLine($"За {x} часа ще се напълни басейнът, ако и двете тръби работят едновременно.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}