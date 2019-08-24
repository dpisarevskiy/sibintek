using System;

namespace ChinemaChain{
        public class Tiket {
        private string name;
        private decimal price;
        private decimal amount;

        public Tiket (string n, decimal p) {
            name = n;
            price = p;
            amount = 0;
        }

        public string Name{
            get { return name; } set { name = value; }
        }


        public decimal Price{
            get { return price; } set { price = value; }
        }

        public decimal Amount{
            get { return amount; } set { amount = value; }
        }

    }
}