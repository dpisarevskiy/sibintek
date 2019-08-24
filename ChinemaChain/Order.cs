using System;
using System.Collections.Generic;

namespace ChinemaChain{
    class Order{
        public Tiket Tikets{ get; set; }
        public Schedule Schedule{ get; set;}
        public Customer CustomerId{ get; set; }
        public Guid OrderID{ get; set; }

        public Order(Tiket t,Customer c, Schedule s)
        {
            Tikets = t;
            CustomerId = c;
            Schedule = s;
            OrderID = Guid.NewGuid();
        }
        public void Print()
        {
            Console.WriteLine($"Ticket - {Schedule.Movie.Title} in {Schedule.Date} {Schedule.ChinemaHall.Name} by {CustomerId.Name} price - {Tikets.Price} ");
        }

    }
}