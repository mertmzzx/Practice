namespace Zad26
{
    using System.Text;

    public class ItemList
    {
        public ItemList()
        {
            this.Items = new List<Item>();
        }

        public List<Item> Items { get; set; }

        public int Size() => this.Items.Count;

        public Item Get(int index)
        {
            if (index <= this.Size() && index >= 0 && index != null)
            {
                return this.Items[index];
            }

            throw new Exception("Невалиден индекс!");
        }

        public void Add(Item item)
        {
            if (this.Items.Contains(item))
            {
                throw new Exception("Стоката вече е в списъка!");
            }

            this.Items.Add(item);
            this.Items.Sort();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Items)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
