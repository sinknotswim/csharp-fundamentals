namespace Exercise14;
public class Exercise14
{
    static void Main()
    {
        IceCreamArray();
        KCScores();
    }
    public static void IceCreamArray() //q1 method
    {
        string[] IceCream = new string[3];
        IceCream[0] = "chocolate";
        IceCream[1] = "vanilla";
        IceCream[2] = "mint";
        string[] IceCream2 = { "chocolate", "vanilla", "mint" };
        string[] IceCream3 = new string[] { "chocolate", "vanilla", "mint" };

        foreach (var item in IceCream) //foreach prints array
        {
            Console.WriteLine(item);
        }
    }
    public static void KCScores() //q2 method
    {
        int[,] Scores = new int[2, 2]; //2nd number is away team listed FIRST
        Scores[34, 20] = 0;
        Scores[23, 20] = 0;
        Scores[20, 34] = 0;
        Scores[26, 10] = 0;
        Scores[32, 40] = 0;

        foreach (var item in Scores) //foreach prints array
        {
            Console.WriteLine(item);
        }
    }
}