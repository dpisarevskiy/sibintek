using System;
namespace ChinemaChain{

    public class Schedule{
        public Guid Id { get; set; } 
        public string Date{get;set;}
        public Movie Movie{get;set;}
        public ChinemaHall ChinemaHall{get;set;}
        public decimal Price{get;set;}

        public int Seats{get;set;}
        public int VipSeats{get;set;}


        public Schedule(Movie m, ChinemaHall c, string d, decimal p)
        {
            Date = d;
            Movie = m;
            ChinemaHall = c;
            Price = p;
            Id = Guid.NewGuid();
            Seats = c.Seats;
            VipSeats = c.VipSeats;
        }

        public string PrintSchedule()
        {
           return $"{Movie.Title} in {ChinemaHall.Name} price: siple {Price} RUB,VIP:{ Price * 2 } RUB";
        }
    }
}