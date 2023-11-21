namespace F02_T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вложена сума: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Годишна лихва(в %): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Период: ");
            int n = int.Parse(Console.ReadLine());

            double x = (1 + b / 100);

            double k = a * Math.Pow(x, n);

            Console.Write("Крайна сума: ");
            Console.WriteLine(k);
        }
    }
}