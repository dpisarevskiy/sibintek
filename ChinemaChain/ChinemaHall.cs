using System;
using System.Collections.Generic;
namespace ChinemaChain{
    public class ChinemaHall{

        public string Name{get;set;}
        public int ScreenSize{get;set;}

        public ChinemaHall(string n, int s)
        {
            Name = n;
            ScreenSize = s;
        }

    }
}