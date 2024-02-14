namespace Zad26
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ItemList itemList = new ItemList();

                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new Exception("Невалидни данни!");
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Напишете описание на стоката: ");
                    string description = Console.ReadLine();

                    Console.Write("Напишете цена на стоката: ");
                    double price = double.Parse(Console.ReadLine());

                    Item item = new Item(description, price);
                    itemList.Add(item);
                }

                Console.WriteLine(itemList.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
        }
    }
}