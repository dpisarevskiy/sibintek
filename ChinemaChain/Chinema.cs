using System;
using System.Collections.Generic;

namespace ChinemaChain{
    public class Chinema:IChinema{
        public string Name{get;set;}
        public List<Schedule> schedule = new List<Schedule>();
        public List<ChinemaHall> chinemaHalls = new List<ChinemaHall>();

        public void Print()
        {
            Console.WriteLine($"Today in {Name}:");
            foreach(Schedule s in schedule)
            {
                Console.WriteLine(s.PrintSchedule());
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public Chinema(string n)
        {
            Name = n;
        }

        public void AddSchedule(Schedule s)
        {   
            
            if(chinemaHalls.Contains(s.ChinemaHall))
            {
                schedule.Add(s);
            } else {
                Console.WriteLine($"This Screen not supported by {Name}");
            }
        }

        public void RemoveScedule(Schedule s)
        {
            schedule.Remove(s);
        }

        public void AddHall(ChinemaHall hall)
        {
            chinemaHalls.Add(hall);
        }

        public void RemoveHall(ChinemaHall hall)
        {
            chinemaHalls.Remove(hall);
        }

    }
}