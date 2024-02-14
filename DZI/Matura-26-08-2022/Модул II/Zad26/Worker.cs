namespace Zad26
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int age, decimal wage, int workHours) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workHours;
        }

        public decimal Wage { get; }

        public int WorkHours { get; }

        public decimal Salary()
        {
            return this.WorkHours * this.Wage;
        }

        public override string ToString()
        {
            return base.ToString() + $", salary: {Salary():f2}";
        }
    }
}
