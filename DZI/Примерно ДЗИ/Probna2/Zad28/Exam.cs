namespace Zad28
{

    public class Exam
    {
        public Exam(string subject, DateTime date, decimal quotient, decimal grade, string type)
        {
            Subject = subject;
            Date = date;
            Quotient = quotient;
            Grade = grade;
            Type = type;
        }

        public string Subject { get; set; }

        public DateTime Date { get; set; }

        public decimal Quotient { get; set; }

        public decimal Grade { get; set; }

        public string Type { get; set; }

        public decimal FinalGrade()
        {
            return Quotient * Grade;
        }

        public override string ToString()
        {
            decimal fGrade = FinalGrade();
            return $"The exam in the subject of {Subject} dated {Date} has a final grade of {fGrade:f2}";
        }
    }
}
