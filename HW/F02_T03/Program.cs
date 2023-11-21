namespace F02_T03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for 
                (int i = n-1; i < n; i--)
            {
                if (i <= 0)
                {
                    break;
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}