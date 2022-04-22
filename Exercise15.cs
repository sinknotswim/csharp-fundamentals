namespace Exercise15;

public enum FavoriteMovies { Thing, Scream, Ringu, Conjuring };
public class Exercise15
{
    public static String Favs(FavoriteMovies movies)
    {
        string message = movies switch
        {
            FavoriteMovies.Thing => $"My favorite movie is {FavoriteMovies.Thing}",
            FavoriteMovies.Scream => $"My favorite movie is {FavoriteMovies.Scream}",
            FavoriteMovies.Ringu => $"My favorite movie is {FavoriteMovies.Ringu}",
            FavoriteMovies.Conjuring => $"My favorite movie is {FavoriteMovies.Conjuring}",
            _ => "Sorry, that's not valid."
        };
        return message;
    }
    //Write a method that takes an enum parameter. This enum will be your favorite movie
    //enum. The method will have a tuple return type(int num, string movie).
    //Using an explicit int cast on one of your enum, assign the value to an int variable.
    //Create second variable of type string. Assign the same enum value you used and use
    //the ToString() at the end of it.Return both variables as a tuple.
    public Tuple TupleExample(FavoriteMovies movies)
    {
        (int, string) example = (1, "Scream");
        Console.WriteLine(example);
        int value = (int)Enum.Value;
        string movies = Enum.Value.ToString();
        Console.WriteLine(example);
    }
    static void Main()
    {
        Console.WriteLine(Favs(FavoriteMovies.Scream));
    }

}