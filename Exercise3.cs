namespace Exercise3;

/*
Exercise3
 */
public class Exercise3
{
    /*
    my static main, to call my functions
    */
    static void Main()
    {
        int value = Question1(2);
        Console.WriteLine(value);
        Question2();
        Question3(5, 10);
        Question4(true, false);
    }

    static int Question1(int zero)
    {
        /*
        my function takes 1 int argu and returns an int type,
        consolewriteline for the first 4 and for the 5th, an int return
        */
        int a = 15;
        int b = 456;
        int c = 23;
        int d = 89;
        int e = 245;
        Console.WriteLine(a % zero);
        Console.WriteLine(b % zero);
        Console.WriteLine(c % zero);
        Console.WriteLine(d % zero);
        int f = e % zero;
        return f;
    }

    static void Question2()
    {
        /*
        my function takes no arguments and solves three different problems
        with consolewriteline, using the same arithmatic but with different
        parenthesis to result in different answers
        */
        int totala = 10 + 32 * 12 / 3;
        int totalb = (10 + 32 * 12) / 3;
        int totalc = (10 + 32) * 12 / 3;
        Console.WriteLine(totala);
        Console.WriteLine(totalb);
        Console.WriteLine(totalc);
    }

    static void Question3(short one, short two)
    {
        /*
        q3, I solve each compound with a consolewriteline
        */
        one += two;
        Console.WriteLine(one);
        one /= two;
        Console.WriteLine(one);
        one *= two;
        Console.WriteLine(one);
        one %= two;
        Console.WriteLine(one);
    }

    static void Question4(bool arg1, bool arg2)
    {
        /*
        by and large I didn't really understand this part so I tried to do
        what we did in the videos and inputted my outputs in comments
        */
        Console.WriteLine("Argument1=True, Argument2=False");
        Console.WriteLine(arg1 & arg2);
        //false
        Console.WriteLine("Argument1=False, Argument2=False");
        Console.WriteLine(arg1 | arg2);
        //true
        Console.WriteLine("Argument1=True, Argument2=True");
        Console.WriteLine(arg1 ^ arg2);
        //true
        Console.WriteLine("Argument1=False, Argument2=True");
        Console.WriteLine(arg1 || arg2);
        //true
    }

} // end class
