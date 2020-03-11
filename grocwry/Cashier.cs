﻿using System;
using System.Collections.Generic;
using System.Text;

namespace grocwry
{
    public class Cashier
    {
        public string name;
        public int counterNumber;

        public Cashier()
        {
            name = "";
            counterNumber = 1;
        }

        public Cashier(string n, int c)
        {
            name = n;
            counterNumber = c;
        }

        public string GetName() { return name; }
        public int GetCounterNumber() { return counterNumber; }
        public void SetName(string n) { name = n; }
        public void SetCounterNumber(int c) { counterNumber = c; }

        public void DisplayTotal(Order o1, Order o2, Order o3)
        {
            Console.Write("\nTotal: ");
            Console.WriteLine(o1.GetTotalPrice() + o2.GetTotalPrice() + o3.GetTotalPrice());
        }
        public void ToString()
        {
            Console.WriteLine("Paid for " + GetName() + 
                " of Counter " + GetCounterNumber());
        }
    }
}
