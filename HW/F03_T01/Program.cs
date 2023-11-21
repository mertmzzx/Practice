namespace F03_T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());

                double temp = num1;

                num1 = num2;
                num2 = temp;

                Console.WriteLine(num1);
                Console.WriteLine(num2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}