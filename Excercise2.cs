namespace Exercise2;

/*
 The class description describes the Exercise Lab from a class level.
 The class name should reflect the lab name... Exercise1. To get credit you
need to provide the direct link to the exercise file from GitHub. If the
instructions ask you to create more than 1 file, include links for each file.
 */
public class Exercise2
{

    /*
     Include comments like this before each exercise number. The comment should include
     the exercise number and its information. If more than one method is required, this will
    be written once for that exercise number. The method name will be defined
    in the lab.
     */
    static void Main()
    {
        Question1("EXERCISE two Lab");
        Question2();
        Question3();
        Question4();
    }
    //q1 string exercise
    static void Question1(string arg)
    {
        Console.WriteLine(arg.Trim());
        Console.WriteLine(arg.ToLower());
        Console.WriteLine(arg.Contains("Tow"));
        Console.WriteLine(arg.Length);
        Console.WriteLine(arg.IndexOf('C'));
    }
    //q2 unicode
    static void Question2()
    {
        char value = '\u00B6';
        Console.WriteLine(value);
    }
    //q3 escape sequences
    static void Question3()
    {
        string Rhyme = "Jack and Jill\nWent up the hill\nto fetch a pail of water.\nJack fell down and broke his crown\nand Jill came tumbling after.";
        Console.WriteLine(Rhyme);
    }
    //q4 interpolation
    static String Question4()
    {
        string Name = "Li";
        string Movie = "A Silent Voice";
        string Snack = "popcorn";
        string Drink = "Coke";
        return $"My name is {Name}, my favorite movie is {Movie}, my favorite movie snack is {Snack}, and my favorite drink is {Drink}.";
    }

} // end class
