using Q2;

class Program
{
    public static void Main()
    {
        Movie<string> movieName = new Movie<string>();
        Console.WriteLine(movieName.displayTag("Movie name") + movieName.displayData("Inception"));
        Movie<int> movieRating = new Movie<int>();
        Console.WriteLine(movieRating.displayTag(10) + " / " + movieRating.displayData(9));

    }
}