namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете число: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("Въведеното число е кратно на 5.");
            }
            else
            {
                Console.WriteLine("Въведеното число не е кратно на 5.");
            }
        }
    }
}