namespace Exercise6;

/*
the information I used is attatched in void Main(),
but to clarify, it was size 22 and Nike
 */
 class Exercise6
{

    /*
     defining Q1 code snippits
     */
    public int _showSize;
    public string _shoeType;

    public int shoeSize
    {
        get { return _showSize; } //properties. for q2. public and capital
        set { _showSize = value; }
    }

    public string shoeType
    {
        get { return _shoeType; } //properties. for q2. public and capital
        set { _shoeType = value; }
    }
    static void Main()
    {
        //default Constructor
        Exercise6 myExercise6 = new Exercise6(22, "Nike");
        Exercise6.TryOn theShoe = myExercise6.TryOnShoe();

        theShoe($"I tried on a {myExercise6.shoeType} shoe that was my size, {myExercise6.shoeSize}");
    }
    //Q1 constructor w 2 parameters, int and string, private class vari defined with _
    //associate constructor parameters inside constructor
    public Exercise6(int showSize, string shoeType)
    {
        _showSize = showSize;
        _shoeType = shoeType;
        Console.WriteLine($"Shoe Size and Type: {showSize}, {shoeType}");
    }

    public delegate void TryOn(string type); //q3. delegate called tryon.

    public void TryOnShoe(string message) //method takes string argument and void return.
    {
        Console.WriteLine(message);
    }

} // end class