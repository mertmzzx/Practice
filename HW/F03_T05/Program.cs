namespace F03_T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double c = double.Parse(Console.ReadLine());

                Console.Write("D1 = ");
                double d1 = double.Parse(Console.ReadLine());
                Console.Write("D2 = ");
                double d2 = double.Parse(Console.ReadLine());
                Console.Write("D3 = ");
                double d3 = double.Parse(Console.ReadLine());

                double x = (a * b * c) / (d1 + d2 + d3);

                Console.WriteLine($"Басейнът ще се напълни за {Math.Ceiling(x)} часа, ако и триите тръби работят едновременно.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}