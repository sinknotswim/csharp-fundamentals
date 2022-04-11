namespace Exercise8;

public class Exercise8
{
    public const int Foot = 12; //12 inc in foot

    static void Question1(int Value)
    {
        int newValue = Value * Foot; //formula to convert parameter to inch
        Console.WriteLine(newValue); //print statement
    }
    static void Question2(int Length, int Width)
    {
        int areaValue = Length * Width; //formula for length * width
        Console.WriteLine(areaValue); //print formula result
    }
    //main func
    static void Main()
    {
        Question1(3); //3 is value
        Question2(2, 4); //2 = length, 4 = width
    }

} // end class
