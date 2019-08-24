using System;
using System.Collections.Generic;

namespace ChinemaChain{

    public class Schedule{

        public string Date{ get; set; }
        public Movie Movie{ get; set; }
        public ChinemaHall ChinemaHall{ get; set; }
        public List<Tiket> Tikets{ get; set; }

        public Schedule(Movie m, ChinemaHall c, string d)
        {
            Date = d;
            Movie = m;
            ChinemaHall = c;
        }

        public string PrintSchedule()
        {
           return $"{Movie.Title} in {ChinemaHall.Name}";
        }
    }
}