using System;

public class Movie{
    private string title;
    private int duration;
    public int Duration{
        get{ return duration; } set { duration = value; }
    }
    public string Title{
        get{ return title; } set { title = value; }
    }

    public Movie(string t, int d){
        Title = t;
        Duration = d;
    }
}