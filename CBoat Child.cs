namespace Boat;
class Boat
{
    private int _seats; //int declared
    private int _speed;
    private string _color;
    public int Seats //int used
    {
        get => _seats;
        set => _seats = value;
    }
    public int BoatSpeed
    {
        get => _speed;
        set => _speed = value;
    }
    public string Color
    {
        get => _color;
        set => _color = value;
    }

    public Boat(int Seats, int BoatSpeed, string Color)
    {
        Console.WriteLine(Seats);
        Console.WriteLine(BoatSpeed);
        Console.WriteLine(Color);
    }
    public Boat(int Seats, int BoatSpeed)
    {
        this.Seats = Seats;
        this.BoatSpeed = BoatSpeed;
    }
    public Boat()
        : this(4, 100, "Red") { }
}
class Yacht : Boat
{
    private string _sailColor;
    private int _sailNumber;

    public string SailColor //int used
    {
        get => _sailColor;
        set => _sailColor = value;
    }
    public int SailNumber //int used
    {
        get => _sailNumber;
        set => _sailNumber = value;
    }
    public Yacht(string SailColor) //base + 3 params
        : base()
    { Console.WriteLine(SailColor); }
    public Yacht(int SailNumber) //second constructor, 2 params from horse + this child param
        : this("Short") { Console.WriteLine(SailNumber); }
    public Yacht() //second constructor, 2 params from horse + this child param
        : this("Long") { this.SailNumber = SailNumber; Console.WriteLine(SailNumber); }
}