namespace Zad26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                if (a < 10 || b < 10 || a > 100000 || b > 100000 || a > b)
                {
                    Console.WriteLine("Задайте коректен интервал, необходимо е a < b");
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                }

                Console.Write("Числата са: ");
                for (int i = a; i < b; i++)
                {
                    bool check = Check(i);

                    if (check)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public static bool Check(int x)
        {
            int last = 0;
            if (x > 100)
            {
                last = (x / 10) % 10;
            }
            else
            {
                last = x / 10;
            }

            int curr = x % 10;

            if (curr <= last)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}