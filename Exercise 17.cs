namespace Exercise17;

public class Exercise17
{

    public static void Question1(int one, int two)
    {
        try
        {
            int three = one / two;
            Console.WriteLine($"The first int is {one}, the second is {two}. This is the result of one/two: {three}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Null reference: {ex.Message}");
        }
    }

    public static void Question2(string Horse)
    {
        if(Horse == null)
        {
            throw new NullReferenceException("Horse is null.");
        }
        else
        {
            Console.Write(Horse);
        }
    }

}