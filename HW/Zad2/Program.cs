namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете три имена: ");
            string fullName = Console.ReadLine();

            Console.Write("Въведете номер на шофьорска книжка: ");
            int driverLicense = int.Parse(Console.ReadLine());

            Console.Write("Въведете брой натрупани нарушения: ");
            int violations = int.Parse(Console.ReadLine());

            Console.Write("Въведете сума от глоби: ");
            double amountFees = double.Parse(Console.ReadLine());

            Driver driver = new Driver(fullName, driverLicense, violations, amountFees);

            Console.Write("Получихте глоба! Въведете стойността на глобата: ");
            double fee = double.Parse(Console.ReadLine());

            driver.RegisterViolation(fee);
            driver.CheckStatus();

            Console.WriteLine($"Статус на книжката: {driver.Status}.");
            
        }
    }
}