using System;

namespace ChinemaChain{
    public class Order{
        public Schedule SceduleId{get;set;}
        public Customer CustomerId{get;set;}
        public Guid OrderID{get;set;}
        public bool Valid{get;set;}
        public bool Vip{get;set;}

        public decimal Price{get;set;}

        public Order(Schedule s,Customer c, bool vip)
        {
            SceduleId = s;
            CustomerId = c;
            Vip = vip;
            OrderID = Guid.NewGuid();

                if(Vip == true)
                {
                    if(SceduleId.VipSeats>1)
                    {
                        SceduleId.VipSeats--;
                        Price = SceduleId.Price*2;
                        Valid = true;
                    } 
                        else 
                    {
                        Valid = false;
                    }
                }
                    else
                {
                    if(SceduleId.Seats>1)
                    {
                        SceduleId.Seats--;
                        Price = SceduleId.Price;
                        Valid = true;
                    }
                        else 
                    {
                        Valid = false;
                    }
                }
            
        }
        public void Print()
        {
            Console.WriteLine($"Ticket Valid({Valid}) - {OrderID}, {SceduleId.Movie.Title} in {SceduleId.Date} {SceduleId.ChinemaHall.Name} Vip:{Vip} by {Price} on {CustomerId.Name} ");
        }


    }
}