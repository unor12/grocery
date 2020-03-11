using System;
using System.Collections.Generic;
using System.Text;

namespace grocwry
{
    public class Order : Products
    {
        public int quantity;
        private double totalPrice;

        public Order() : base() 
        {
            quantity = 0; 
        }
        public Order(string i, double p, int q) : base(i, p) 
        {
            quantity = q;
        }

        public double GetQuantity() { return quantity; }
        public double GetTotalPrice()
        {
            CalcTotalPrice();
            return totalPrice;
        }
        public void SetQuantity(int q) { quantity = q; }
        private void CalcTotalPrice()
        {
            totalPrice = GetPrice() * GetQuantity();
        }

        public void ToString()
        {
            Console.WriteLine(GetItemName() + " " + GetPrice() + " x " 
                + GetQuantity() + " " + GetTotalPrice());
        }
    }
}
