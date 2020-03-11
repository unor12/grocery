using System;
using System.Collections.Generic;
using System.Text;

namespace grocwry
{
    public class Products
    {
        public string itemName;
        public double price;
       

        public Products()
        {
            itemName = "";
            price = 0;
        }

        public Products(string i, double p)
        {
            itemName = i;
            price = p;
        }

        public string GetItemName() { return itemName; }
        public double GetPrice() { return price; }
  

        public void SetItemName(string n) { itemName = n; }
        public void SetPrice(double p) { price = p; }
    }
}
