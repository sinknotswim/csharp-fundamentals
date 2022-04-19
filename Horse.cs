namespace MyFirstApplication;

class Horse
{
    public string Breed { get; set; }
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
        : this("Shire", 100, "Shorthair") { }

}
class Program
{
    static void Main()
    {
        Horse one = new Horse("Arabian", 100, "Shorthair");
        Horse two = new Horse(100, "Longhair");
        Horse three = new Horse();
        Boat first = new Boat(2, 50, "Blue");
        Boat second = new Boat(4, 50);
        Boat third = new Boat();
    }
}