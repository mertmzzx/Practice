namespace F03_T08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("T1 = ");
                double t1 = double.Parse(Console.ReadLine());
                Console.Write("V1 = ");
                double v1 = double.Parse(Console.ReadLine());

                Console.Write("T2 = ");
                double t2 = double.Parse(Console.ReadLine());
                Console.Write("V2 = ");
                double v2 = double.Parse(Console.ReadLine());

                double S = (t1 * v1) + (t2 * v2);
                double v = S / (t1 + t2);

                Console.WriteLine($"Средната скорост на автомобила е {(int)v} km/h.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}