namespace Exercise4;

/*
Lab4 of All About Data
 */
public class ExerciseTemplate
{

    /*
     My main to call my questions
     */
    static void Main()
    {
        Question1("and", "or");
        /*
        Related to Q2. My type conversion to return the string even though my value is char.
        */
        string value = Question2('A');
        Console.WriteLine("Returned from Question2: " + value);
        Question3();
    }

    static void Question1(string value1, string value2)
    {
        /*
        Q1. I call two strings, value 1 and 2, and check if equal. I used "and" and "or".
        */
        if (value1 == value2)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
    }

    static String Question2(char grade)
    {
        /*
        Q2. I call a char value that checks a switch and returns a string descriptor.
        */
        switch (grade)
        {
            case 'E':
                return "Your grade is Excellent.";
            case 'V':
                return "Your grade is Very Good.";
            case 'G':
                return "Your grade is Good.";
            case 'A':
                return "Your grade is Average.";
            case 'F':
                return "Your grade is Fail.";
            default:
                return "That is not a valid grade.";
        }
    }

    static void Question3()
    {
        /*
        Q3. I have a for statement that for 0-30 increments and tests if divisible by 0
        */
        for (int i = 0; i < 30; i++)
        {
            if (i % 3 == 0)
                Console.WriteLine(i);
        }
    }

} // end class
