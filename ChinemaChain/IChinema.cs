using System;
namespace ChinemaChain{

    public interface IChinema{
        void AddHall(ChinemaHall hall){}
        void RemoveHall(ChinemaHall hall){}
        void AddSchedule(Schedule s){}
        void RemoveSchedule(Schedule s){}

        void Print(){}
    }
}