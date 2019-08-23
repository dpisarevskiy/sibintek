using System;
using System.Collections.Generic;

namespace ChinemaChain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            List<IChinema> chinema = new List<IChinema>();
            List<Order> orders = new List<Order>();

            IChinema chinema1 = new Chinema("Luxor");
            IChinema chinema2 = new Chinema("Formula Kino");
            ChinemaHall screenA = new ChinemaHall("Holywood",150,10,2);
            ChinemaHall screenB = new ChinemaHall("HongKong",200,11,3);
            ChinemaHall screenC = new ChinemaHall("London",300,5,2);
            chinema1.AddHall(screenA);
            chinema1.AddHall(screenB);
            chinema1.AddHall(screenC);

            chinema2.AddHall(screenA);
            chinema2.AddHall(screenB);

            Movie movie1 = new Movie("Spider-Man: Far From Home",90);
            Movie movie2 = new Movie("Pirates of the Caribbean",120);
            Movie movie3 = new Movie("The Godfather",120);
            Movie movie4 = new Movie("Toy Story 4",120);
            Movie movie5 = new Movie("Avengers Endgame",120);
            Movie movie6 = new Movie("Once Upon A Time In Hollywood",120);
            Movie movie7 = new Movie("Rocketman",120);
            Movie movie8 = new Movie("John Wick: Chapter 3 - Parabellum",120);

            Schedule s1 = new Schedule(movie1,screenA,"13:00", 500);
            Schedule s2 = new Schedule(movie2,screenC,"14:40", 500);
            Schedule s3 = new Schedule(movie3,screenB,"18:00", 600);
            Schedule s4 = new Schedule(movie4,screenC,"21:40", 700);
            Schedule s5 = new Schedule(movie5,screenA,"23:40", 900);

            Schedule s6 = new Schedule(movie1,screenA,"11:40", 1000);
            Schedule s7 = new Schedule(movie7,screenB,"14:40", 1200);
            Schedule s8 = new Schedule(movie8,screenB,"16:40", 1300);

            chinema1.AddSchedule(s1);
            chinema1.AddSchedule(s2);
            chinema1.AddSchedule(s3);
            chinema1.AddSchedule(s4);
            chinema1.AddSchedule(s5);

            chinema2.AddSchedule(s6);
            chinema2.AddSchedule(s7);
            chinema2.AddSchedule(s8);

            chinema.Add(chinema2);
            chinema.Add(chinema1);

            Customer c1 = new Customer("Dima");
            Customer c2 = new Customer("Petya");
            Customer c3 = new Customer("Vova");
            Customer c4 = new Customer("Ravil");

            orders.Add(new Order(s1,c1,true));
            orders.Add(new Order(s2,c2,true));
            orders.Add(new Order(s3,c3,true));
            orders.Add(new Order(s5,c4,true));
            orders.Add(new Order(s4,c1,false));
            orders.Add(new Order(s3,c2,false));
            orders.Add(new Order(s2,c3,false));
            orders.Add(new Order(s1,c4,false));

            Console.WriteLine("Welcome to chinema:");
            foreach(Chinema c in chinema)
            {
                c.Print();
            }

            Console.WriteLine("Orders:");
            foreach(Order o in orders)
            {
                o.Print();
            }

        }
    }
}
