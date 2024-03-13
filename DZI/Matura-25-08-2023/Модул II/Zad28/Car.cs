namespace Zad28
{
    public class Car
    {
        public Car(string brand, int hP)
        {
            Brand = brand;
            HP = hP;
        }

        public string Brand { get; set; }

        public int HP { get; set; }

        public override string ToString()
        {
            return $"{this.Brand}, {this.HP}";
        }
    }
}
