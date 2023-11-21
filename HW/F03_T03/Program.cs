namespace F03_T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Въведете дължини на двете основи: ");
                double a = double.Parse(Console.ReadLine());

                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Въведете дължина на височината: ");

                double h = double.Parse(Console.ReadLine());

                double S = ((a + b) / 2) * h;
                double m = (a + b) / 2;

                Console.WriteLine($"Лицето на трапеца е: {S}");
                Console.WriteLine($"Дължината на средната отсечка е: {m}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}