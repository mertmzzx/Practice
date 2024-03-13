namespace Zad28
{
    public class Pilot
    {
        public Pilot(string name, int age, Car carP, string category)
        {
            Name = name;
            Age = age;
            CarP = carP;
            Category = category;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Car CarP { get; set; }

        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Age}, {Category}, {this.CarP.ToString()}";
        }
    }
}
