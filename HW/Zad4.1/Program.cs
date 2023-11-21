namespace Zad4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете име на продукта: ");
            string name = Console.ReadLine();

            Console.Write("Въведете покупна стойност на продукта: ");
            double buyPrice = double.Parse(Console.ReadLine());

            Console.Write("Въведете продажна стойност на продукта: ");
            double sellPrice = double.Parse(Console.ReadLine());

            Console.Write("Въведете количество: ");
            int quantity = int.Parse(Console.ReadLine());


            Item product = new Item(name, buyPrice, sellPrice, quantity);

            double profitPerOne = product.SellPrice - product.BuyPrice;
            double totalProfit = product.SellPrice * product.Quantity - product.BuyPrice * product.Quantity;

            Console.WriteLine($"Печалба от един продукт: {profitPerOne:f2} лв.");
            Console.WriteLine($"Обща печалба: {totalProfit:f2} лв.");

            double percentProfit = totalProfit / (product.SellPrice * quantity) * 100;

            if (percentProfit < 10)
            {
                Console.WriteLine("Печалбата е занижена.");
            }
            else if (percentProfit >= 10 && percentProfit < 20)
            {
                Console.WriteLine("Печалбата е в норма.");
            }
            else if (percentProfit >= 20)
            {
                Console.WriteLine("Печалбата е завишена.");
            }
        }


    }
}