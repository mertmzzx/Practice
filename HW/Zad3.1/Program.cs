namespace Zad3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Mert\source\repos\HW\Zad3.1/input.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);

                    line = reader.ReadLine();
                }
            }
        }
    }
}