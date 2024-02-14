namespace Zad26
{

    public class Item : IComparable<Item>
    {
        public Item(string description, double price)
        {
            if (description != null && description.Length > 0 && price > 0)
            {
                this.Description = description;
                this.Price = price;
            }
            else
            {
                throw new Exception("Подадените стойности не са валидни!");
            }
        }

        public string Description { get; }

        public double Price { get; }

        public int CompareTo(Item obj)
        {
            if(obj == null) return 1;

            int compare = this.Description.CompareTo(obj.Description);

            if (compare == 0)
            {
               return this.Price.CompareTo(obj.Price);
            }
            else
            {
                return compare;
            }
        }

        public override string ToString()
        {
            return $"{this.Description} ({this.Price:f2})";
        }
    }
}
