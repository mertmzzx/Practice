namespace Zad28
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = Console.ReadLine();
                int k = int.Parse(Console.ReadLine());

                List<int> numbers = new List<int>();

                ReadFromFile(numbers, fileName);
                Delete(numbers, k);
             // Order(numbers); ????

                Console.WriteLine(string.Join(" ", numbers));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
            
        }

        public static void Delete(List<int> list, int k) // A)
        {
            if (list.Count < 0 || list == null || k == null || k <= 0)
            {
                throw new Exception("Невалидни данни!");
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % k == 0)
                {
                    list.Remove(list[i]);
                }
            }
        }

//        public static void Order(List<int> list) => list.OrderBy(number => SumDigits(number)).ToList(); Б) Не работи коректно??

        public static int SumDigits(int number) // Б)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;

                number /= 10;
            }

            return sum;
        }

        public static void ReadFromFile(List<int> numbers, string fileName) // В)
        {
            if (fileName == null || numbers.Count < 0 || numbers == null)
            {
                throw new Exception("Невалидни данни!");
            }

            using (StreamReader reader = new StreamReader(fileName))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    numbers.Add(int.Parse(line));

                    line = reader.ReadLine();
                }

                reader.Close();
            }
        }
    }
}