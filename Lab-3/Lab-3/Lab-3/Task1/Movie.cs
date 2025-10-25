namespace Lab_3.Task1;

public class Movie
{
    public string Title;
    public string Director;
    public int Duration;

    public Movie(string title, string director,  int duration)
    {
        Title = title;
        Director = director;
        Duration = duration;
    }
    public void Details()
    {
        Console.WriteLine($"Title: {Title},  Director: {Director}, Duration: {Duration}");
    }

    public void ShortenDuration()
    {
        int temp = Duration % 10; // 67 => temp = 7
        Duration -= temp; // Durateion - temp; 67 - 7 = 60
        Console.WriteLine($"Shortening duration: {Duration}");
    }
}