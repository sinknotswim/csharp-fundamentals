namespace Exercise5;

public class Exercise5
{

    /*
     my main func, to call
    */
    static void Main()
    {
        Func<int, int, int> Vol = Question1;
        Console.WriteLine(Vol(5, 10)); //using func<int,int,int> + lambda to determine vol

        Question2('A'); // calling both functions just to ensure they work as intended
        Console.WriteLine(Question2('A'));

        Question3(3);
    }
    /*
     question 1, where I declare current and resistance as ints and set up the calculations
    */
    static int Question1(int Current, int Resistance)
    {
        int Voltage = Current * Resistance;
        return Voltage;
    }
    /*
     the string expression.
     */
    static string Question2(char Grade)
    {
        string result = Grade switch
        {
            'E' => "Your grade is Excellent.",
            'V' => "Your grade is Very Good.",
            'G' => "Your grade is Good.",
            'A' => "Your grade is Average.",
            'F' => "Your grade is Fail.",
            _ => "That is not a valid grade."
        };
        return result;
    }
    /*
     determines size of popcorn and prints
     */
    static void Question3(int Size)
    {
        string result = Size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie sack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don't have that size."
        };
        Console.WriteLine(result);
    }

}