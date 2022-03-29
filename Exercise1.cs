namespace Exercise1;

/*
 this is the name
 */
public class Exercise1
{

    /*
     this is the class that will hold my method. except it doesn't
    have anything because I have no arguments.
     */
    static void Main()
    {
        int decimalNotation = 35;
        int binaryNotation = 0b_00100011;
        int hexadecimalNotation = 0x_23;
        Console.WriteLine(decimalNotation);
        Console.WriteLine(binaryNotation);
        Console.WriteLine(hexadecimalNotation);

        /*
        these are variables, the number 35 in decimal hex and binary
        */

        Question2(1, 2, 3);

        /*
         This calls the Question 2 function.
         */

        Question3(1, 2, 3);

        /*
         This calls the Question 3 function.
         */

        Question4();

        /*
         This calls the Question 4 function.
         */

    }

    static void Question2(byte arg0, short arg1, int arg2)
    {
        int newarg0 = arg0;
        short newarg1 = arg1;
        float newarg2 = arg2;
        
        Console.WriteLine(arg0);
        Console.WriteLine(arg1);
        Console.WriteLine(arg2);
    }

    static void Question3(double arg3, float arg4, long arg5)
    {
        arg3 = 1;
        long newarg3 = (long)arg3;
        arg4 = 2;
        int newarg4 = (int)arg4;
        arg5 = 3;
        short newarg5 = (short)arg5;

        Console.WriteLine(arg3);
        Console.WriteLine(arg4);
        Console.WriteLine(arg5);
    }

    static void Question4()
    {
        double first = 123456.987;
        int second = -9516248;
        ushort third = 3500;
        int fourth = 988562486;
        double fifth = 19733.14895;
        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine(fourth);
        Console.WriteLine(fifth);
    }

} 


