using System;
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

        public void ToString()
        {
            Console.WriteLine("Paid for " + GetName() + " of Counter " + GetCounterNumber());
            
        }
    }
}
