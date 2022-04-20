namespace HorseChild;

class Horse
{
    public string Breed { get; set; } //auto
    public int Speed { get; set; }
    public string Coat { get; set; }
    //breed, running speed, coat type, all 

    public Horse(string Breed, int Speed, string Coat) //const, has same name as class
    {
        Console.WriteLine(Breed);
        Console.WriteLine(Speed);
        Console.WriteLine(Coat);
    }

    public Horse(int Speed, string Coat) //const 2 parameters, this keyword
    {
        this.Speed = Speed;
        this.Coat = Coat;
    }

    public Horse()
        : this("Arabian", 100, "Shorthair") { }

    public virtual void RideHorse()
    {
        Console.WriteLine("I rode a horse.");
    }

    public void RideHorse(string Breed)
    {
        Console.WriteLine($"I rode a {Breed} horse.");
    }

}
//arabian, neck, high
class Arab : Horse
{
    public string Neck { get; set; }
    public int Height { get; set; }
    public Arab(string Neck) //base + 3 params
        : base()
    { Console.WriteLine(Neck); }
    public Arab(int Height) //second constructor, 2 params from horse + this child param
        : this("Short") { Console.WriteLine(Height); }
    public Arab() //second constructor, 2 params from horse + this child param
        : this("Long") { this.Height = Height; Console.WriteLine(Height); }

    public override void RideHorse()
    {
        Console.WriteLine("I rode an Arabian horse.");
    }

}

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

    public virtual void RideBoat()
    {
        Console.WriteLine("I rode a boat.");
    }

    public void RideHorse(string Color)
    {
        Console.WriteLine($"I rode a {Color} boat.");
    }
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

    public override void RideBoat()
    {
        Console.WriteLine("I rode a Yacht.");
    }
}
class Program
{
    static void Main()
    {
        Arab one = new Arab("Long");
        Arab two = new Arab(50);
        Arab three = new Arab();
        
    }
}