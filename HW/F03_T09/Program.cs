namespace F03_T09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Въведете катетите на първия триъгълник:");
                double a1 = double.Parse(Console.ReadLine());
                double b2 = double.Parse(Console.ReadLine());

                Console.Write("Въведете дължина на катет A2 на втория триъгълник: ");
                double a2 = double.Parse(Console.ReadLine());

                if (a1 <= 0 || b2 <= 0 || a2 <= 0)
                {
                    throw new ArgumentException("Дължините на катетите трябва да са по-големи от 0!");
                }

                double P1 = a1 * b2 / 2;
                double P2 = Math.Pow(a2 / a1, 2) * P1;

                Console.WriteLine($"Лицето на първия триъгълник е = {P1} см2");
                Console.WriteLine($"Лицето на втория триъгълник е = {P2} см2");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}