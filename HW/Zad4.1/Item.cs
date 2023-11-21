namespace Zad4._1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Item
    {
        public Item(string name, double buyPrice, double sellPrice, int quantity)
        {
            this.Name = name;
            this.SellPrice = sellPrice; 
            this.Quantity = quantity;
            this.BuyPrice = buyPrice;
        }

        public string Name { get; set; }

        public double BuyPrice { get; set; }

        public double SellPrice { get; set; }

        public int Quantity { get; set; }


    }
}
