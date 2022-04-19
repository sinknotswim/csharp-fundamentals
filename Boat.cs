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
