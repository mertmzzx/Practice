namespace F03_T14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.Write(n % 10 + " ");
                n /= 10;
            }
        }
    }
}