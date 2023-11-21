namespace T06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете стойности за p,q и a: ");
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int p = numbers[0];
            int q = numbers[1];
            int a = numbers[2];

            if (p > q)
            {
                int temp = q;

                q = p;
                p = temp;
            }
            

            if (a >= p && a <= q)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("не");
            }
        }
    }
}