namespace Zad26
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Задайте брой хора:");
                int n = int.Parse(Console.ReadLine());

                List<Human> people = new List<Human>();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("First name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Last name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Your choice[s - student] , [w - worker]: ");
                    char type = char.Parse(Console.ReadLine());

                    if (type == 's')
                    {
                        Console.Write("Grade: ");
                        double grade = double.Parse(Console.ReadLine());

                        Human student = new Student(firstName, lastName, age, grade);
                        people.Add(student);
                    }
                    else
                    {
                        Console.Write("Wage: ");
                        decimal wage = decimal.Parse(Console.ReadLine());

                        Console.Write("Hours worked: ");
                        int workHours = int.Parse(Console.ReadLine());

                        Human worker = new Worker(firstName, lastName, age, wage, workHours);
                        people.Add(worker);
                    }
                }

                people.Reverse();

                foreach (var p in people)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}