namespace Exercise13;

public interface IMovement //interface with get init
{
    int Speed { get; init; }
}

public abstract class WaterBirds: IMovement //abstract class
{
    public abstract int Speed { get; init; } //implemented from interface as abstract prop

    public abstract void SetSpeed(); //abstract method to set speed to something
    public abstract void TellSpeed(); // abstract method to read speed

    public WaterBirds(int Speed) //const takes int assigns speed
    {
        this.Speed = Speed;
    }
}

public class WaterBirdsDerived : WaterBirds //derived class
{
    public override int Speed { get; init; } = 12; //implement
    public WaterBirdsDerived(int value) //passes value
        : base(value) { }
    public override void SetSpeed() //implement
    {
        int Speed = 0;
        Console.WriteLine(Speed);
    }

    public override void TellSpeed() //implement
    {
        Console.WriteLine(Speed);
    }
}