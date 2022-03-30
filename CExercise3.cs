namespace Exercise3;

/*
 The class description describes the Exercise Lab from a class level.
 The class name should reflect the lab name... Exercise1. To get credit you
need to provide the direct link to the exercise file from GitHub. If the
instructions ask you to create more than 1 file, include links for each file.
 */
public class Exercise3
{

    /*
     Include comments like this before each exercise number. The comment should include
     the exercise number and its information. If more than one method is required, this will
    be written once for that exercise number. The method name will be defined
    in the lab.
     */
    static void Main()
    {
        Question1(2);
    }

    static int Question1(int zero)
    {
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
        Console.WriteLine(f);
        return f;
    }

} // end class
