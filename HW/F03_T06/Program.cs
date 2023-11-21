namespace F03_T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("N1 = ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("N2 = ");
                double n2 = double.Parse(Console.ReadLine());
                Console.Write("N3 = ");
                double n3 = double.Parse(Console.ReadLine());

                double S = n1 + n2 + n3;

                Console.WriteLine($"Общата сума е: {S}");
                Console.WriteLine($"N1 е {(n1 / S) * 100}% от общата сума.");
                Console.WriteLine($"N2 е {(n2 / S) * 100}% от общата сума.");
                Console.WriteLine($"N3 е {(n3 / S) * 100}% от общата сума.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }    
        }
    }
}