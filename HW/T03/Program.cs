namespace T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете чистата заплата: ");
            int salary = int.Parse(Console.ReadLine());

            Console.Write("Въведете бонус: ");
            int bonus = int.Parse(Console.ReadLine());

            Console.Write("Въведете брой продажби: ");
            int sales = int.Parse(Console.ReadLine());

            if (sales > 100)
            {
                Console.WriteLine($"Междинна заплата: {salary}.");
                Console.WriteLine($"Бонус към заплатата: {bonus}.");
                Console.WriteLine($"Крайна заплата: {salary + bonus}");
            }
            else
            {
                Console.WriteLine($"Междинна заплата: {salary} лв.");
                Console.WriteLine($"Бонус към заплатата: 0 лв.");
                Console.WriteLine($"Крайна заплата: {salary}лв.");
            }
        }
    }
}