namespace Zad26
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }

        public double Grade { get;}

        public override string ToString()
        {
            return base.ToString() + $", grade: {this.Grade:f2}";
        }
    }
}
