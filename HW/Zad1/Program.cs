namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n1= rnd.Next();
            int n2= rnd.Next();     
            int n3 = rnd.Next();
            int n4 = rnd.Next();
            int n5 = rnd.Next();
            int n6 = rnd.Next();

            Console.WriteLine($"Генерираните числа са: {n1}, {n2}, {n3}, {n4}, {n5}, {n6}");

            Step2(n1, n2, n3, n4, n5, n6);
            Step3(n1, n2, n3, n4, n5, n6);
        }

        static void Step2 (int n1, int n2, int n3, int n4, int n5, int n6)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

            temp = n3;
            n3 = n4;
            n4 = temp;

            temp = n5;
            n5 = n6;
            n6 = temp;

            Console.WriteLine($"Новите стойности на числата са: {n1}, {n2}, {n3}, {n4}, {n5}, {n6}" );
        }
        static void Step3(int n1, int n2, int n3, int n4, int n5, int n6)
        {
            int temp = n1;
            n1 = n4;
            n4 = temp;

            temp = n2;
            n2 = n5;
            n5 = temp;

            temp = n3;
            n3 = n6;
            n6 = temp;

            Console.WriteLine($"Получените величини са: {n1}, {n2}, {n3}, {n4}, {n5}, {n6}");
        }
    }
}