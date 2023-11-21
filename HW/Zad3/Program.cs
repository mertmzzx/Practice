namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            string cmd = Console.ReadLine();

            while (cmd != "изход от програмата")
            {
                switch (cmd)
                {
                    case "показване на числата":
                        Console.WriteLine($"Първото число е {a} и второто число е {b}");
                        break;
                    case "въвеждане на стойности на числата":
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        break;
                    case "обновяване на стойностите на числата":
                        Random rnd = new Random();
                        a = rnd.Next(-100, 100);
                        b = rnd.Next(-100, 100);
                        break;
                    case "размяна на стойностите на числата":
                        int temp = a;
                        a = b;
                        b = temp;
                        break;
                    case "събиране на числата":
                        Console.WriteLine($"Сбора на числата е {a+b}");
                        break;
                    case "изваждане на числата":
                        Console.WriteLine($"Разликата на числата е {a - b}");
                        break;
                    case "умножение на числата":
                        Console.WriteLine($"Произвдението на числата е {a * b}");
                        break;
                    case "разделяне на числата":
                        Console.WriteLine($"Частното на числата е {a / b}");
                        break;
                    case "по-голямото число":
                        if (a > b)
                        {
                            Console.WriteLine($"По-голямото число е {a}");
                        }
                        else
                        {
                            Console.WriteLine($"По-голямото число е {b}");
                        }
                        break;
                    case "равенство на числата":
                        if (a == b)
                        {
                            Console.WriteLine("Числата са равни");
                        }
                        else
                        {
                            Console.WriteLine("Числата не са равни");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}