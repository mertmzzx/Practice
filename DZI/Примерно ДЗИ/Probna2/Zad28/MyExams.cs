namespace Zad28
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    public class MyExams
    {
        public MyExams(string name)
        {
            Name = name;
            Exams = new List<Exam>();
        }

        public string Name { get; set; }

        public List<Exam> Exams { get; set; }

        public void Add (Exam exam)
        {
            if(Exams.Any(ex => ex.Date == exam.Date))
            {
                throw new Exception("There is an exam on that date!");
            }

            Exams.Add(exam);
            Console.WriteLine("You have succesfully added an exam.");
        }

        public void RemoveLowestScore()
        {
            decimal min = decimal.MaxValue;

            foreach (var e in Exams)
            {
                if (e.FinalGrade() < min)
                {
                    min = e.FinalGrade();
                }
            }

            int count = Exams.RemoveAll(e => e.FinalGrade() == min); 
            Console.WriteLine($"{count} exams have been removed");
        }

        public void ChangeDate(DateTime oldDate, DateTime newDate)
        {
            Exam exam = Exams.FirstOrDefault(ex => ex.Date == oldDate);

            if (exam == null)
            {
                throw new Exception("There is no exam with the given date.");
            }

            int index = Exams.IndexOf(exam);

            Exams[index].Date = newDate;
            Console.WriteLine("Exam's date has been changed.");
        }

        public int CountExams(string type)
        {
            return Exams.FindAll(ex => ex.Type == type).Count();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var e in Exams)
            {
                sb.AppendLine(e.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
