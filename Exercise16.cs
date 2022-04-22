namespace Exercise16;

public class Exercise16
{
    public static void HorseList()
    {
        List<string> myHorseList = new List<string>();
        myHorseList.Add("One Horse");
        myHorseList.Add("Two Horse");
        myHorseList.Add("Three Horse");
        myHorseList.Add("Four Horse");

        foreach (string horse in myHorseList)
        {
            Console.WriteLine(horse);
        }
    }
    public static void MovieDictionary()
    {
        Dictionary<int, string> openWith = new Dictionary<int, string>();
        openWith.Add(1, "The Thing");
        openWith.Add(2, "Scream");
        openWith.Add(3, "Ringu");
        openWith.Add(4, "Conjuring");

        foreach (KeyValuePair<int, string> pair in openWith)
        {
            Console.WriteLine($"For Key: {pair.Key} we have this Movie: {pair.Value}");
        }
    }
    static void Main()
    {
        HorseList();
        MovieDictionary();
    }

}