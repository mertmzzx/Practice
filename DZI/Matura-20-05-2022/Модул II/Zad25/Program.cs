namespace Zad25
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                List<int> numbers = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num < 1)
                    {
                        throw new Exception("Въведете положително число!"); // ???????
                    }

                    numbers.Add(num);
                }

                Dictionary<int, int> kvp = new Dictionary<int, int>();

                for (int i = 0; i < n; i++)
                {
                    int num = numbers[i];
                    if (!kvp.ContainsKey(num))
                    {
                        int count = 0;
                        for (int j = 0; j < n; j++)
                        {
                            if (num == numbers[j])
                            {
                                count++;
                            }
                        }

                        kvp.Add(num, count);
                    }
                }

                foreach (var item in kvp)
                {
                    Console.WriteLine($"число: {item.Key}, брой: {item.Value}");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message); ;
            }
            
        }
    }
}