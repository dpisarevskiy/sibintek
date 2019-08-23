using System;
namespace ChinemaChain{
    public class Customer{
        public string Name{get;set;}
        public Guid Id{get;set;}

        public Customer(string n)
        {
            Name = n;
            Id = Guid.NewGuid();
        }
    }
}