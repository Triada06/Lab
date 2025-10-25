namespace Lab_3.Task1;

public class ActionMovie : Movie
{
    public int StuntsCount;

    public ActionMovie(string title, string director, int duration, int stuntsCount) : base(title, director, duration)
    {
        StuntsCount = stuntsCount;
    }   
    
}