namespace Zad6
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int longest = 0;
            for (int i = 0; i < 3; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int lenght = num.ToString().Length;

                if (lenght > longest)
                {
                    longest = lenght;
                }
            }

            Console.WriteLine(longest);
        }
    }
}