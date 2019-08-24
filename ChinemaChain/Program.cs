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
            ChinemaHall screenA = new ChinemaHall("Holywood",150);
            ChinemaHall screenB = new ChinemaHall("HongKong",200);
            ChinemaHall screenC = new ChinemaHall("London",300);
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

            Schedule s1 = new Schedule(movie1,screenA,"13:00");
            Schedule s2 = new Schedule(movie2,screenC,"14:40");
            Schedule s3 = new Schedule(movie3,screenB,"18:00");
            Schedule s4 = new Schedule(movie4,screenC,"21:40");
            Schedule s5 = new Schedule(movie5,screenA,"23:40");

            Schedule s6 = new Schedule(movie1,screenA,"11:40");
            Schedule s7 = new Schedule(movie7,screenB,"14:40");
            Schedule s8 = new Schedule(movie8,screenB,"16:40");

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

            Console.WriteLine("Welcome to chinema:");
            foreach(Chinema c in chinema)
            {
                c.Print();
            }


            Tiket TiketType1 = new Tiket("Standard", 300);
            Tiket TiketType2 = new Tiket("VIP", 600);
            Tiket TiketType3 = new Tiket("Student", 200);
            Tiket TiketType4 = new Tiket("Child", 150);

            orders.Add(new Order(TiketType1,c1,s1));
            orders.Add(new Order(TiketType2,c2,s2));
            orders.Add(new Order(TiketType3,c3,s3));
            orders.Add(new Order(TiketType4,c4,s5));
            orders.Add(new Order(TiketType1,c1,s4));
            orders.Add(new Order(TiketType1,c2,s3));
            orders.Add(new Order(TiketType1,c3,s2));
            orders.Add(new Order(TiketType1,c4,s1));

            foreach(Order o in orders)
            {
                o.Print();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
