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