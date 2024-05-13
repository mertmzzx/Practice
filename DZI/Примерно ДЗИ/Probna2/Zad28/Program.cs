namespace Zad28
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Student Name: ");
                string name = Console.ReadLine();

                MyExams myExams = new MyExams(name);

                string cmd = Console.ReadLine();
                while (cmd != "Close")
                {
                    string[] token = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    if (token[0] == "Add")
                    {
                        string subject = token[1];
                        DateTime date = DateTime.Parse(token[2]);
                        decimal quotient = decimal.Parse(token[3]);
                        decimal grade = decimal.Parse(token[4]);
                        string type = "";
                        if (token.Length == 7)
                        {
                            type = token[5] + " " + token[6];
                        }
                        else
                        {
                            type = token[5];
                        }

                        if (grade < 2 || grade > 6)
                        {
                            throw new Exception("Invalid grade.");
                        }
                        if (quotient < 0 || quotient > 1)
                        {
                            throw new Exception("Specify a quotient from 0 to 1.");
                        }
                        if (subject.Length <= 0)
                        {
                            throw new Exception("The subject can not be empty.");
                        }
                        if (type != "state matriculation" && type != "candidate student" && type != "language" && type != "external assessment")
                        {
                            throw new Exception("The type can be only state matriculation, candidate student, language or external assessment.");
                        }

                        Exam exam = new Exam(subject, date, quotient, grade, type);
                        myExams.Add(exam);
                    }
                    else if (token[0] == "RemoveLowestScore")
                    {
                        myExams.RemoveLowestScore();
                    }
                    else if (token[0] == "ChangeDate")
                    {
                        DateTime oldDate = DateTime.Parse(token[1]);
                        DateTime newDate = DateTime.Parse(token[2]);
                        myExams.ChangeDate(oldDate, newDate);
                    }
                    else if (token[0] == "CountExams")
                    {
                        string type = "";
                        if (token.Length == 3)
                        {
                            type = token[1] + " " + token[2];
                        }
                        else
                        {
                            type = token[1];
                        }
                        Console.WriteLine($"Number of exams: {myExams.CountExams(type)}");
                    }
                    else if (token[0] == "Print")
                    {
                        Console.WriteLine(myExams.ToString());
                    }

                    cmd = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}