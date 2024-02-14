namespace Zad26
{
    public class Human
    {

        public Human(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get;}

        public string LastName { get; }

        public int Age { get; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, {this.Age} years old";
        }
    }
}
