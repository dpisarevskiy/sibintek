using System;
using System.Collections.Generic;
namespace ChinemaChain{
    public class ChinemaHall{

        public string Name{get;set;}
        public int ScreenSize{get;set;}

        public int Seats{get;set;}
        public int VipSeats{get;set;}

        public ChinemaHall(string n, int s, int seats, int vipseats)
        {
            Name = n;
            ScreenSize = s;
            Seats = seats;
            VipSeats = vipseats;
        }

    }
}