namespace F03_T10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Въведете началната цена на стоката: ");
                double N = double.Parse(Console.ReadLine());

                Console.Write("Въведете първото намаление в %: ");
                double M = double.Parse(Console.ReadLine());

                Console.Write("Въведете второто намаление в %: ");
                double K = double.Parse(Console.ReadLine());

                double B = N - (N * M / 100);

                B -= B * K / 100;

                double P = (N - B) / N * 100;

                Console.WriteLine($"Общото процентно намаление е {P:f2}%");
                Console.WriteLine($"Крайната цена на стоката е {B:f2}лв");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}