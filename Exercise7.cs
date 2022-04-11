namespace Exercise7;

/*
 change type from class to struct, change name of struct to Employee
 */
public struct Employee
{
    //create 2 struct variables, first int _id, second string _name
    int _id;
    string _name;
    //for int id
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    //for string name
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    //constructor that takes two arguments, first int second string, struct variables
    //assign to struct paramaters
    public Employee(int Id, string Name)
    {
        _id = Id;
        _name = Name;
        Console.WriteLine($"ID: {Id} Name: {Name}");
    }
    //main
    static void Main()
    {
        Employee myEmployee = new Employee(20, "Li"); //calling Employee
        Boat boat = new Exercise7.Boat("Blue", 100, 10);//setting params for Boat
        Console.WriteLine(boat); //calling Boat
    }

} // end class
//record: paint color engine max speed number of seats
public record Boat(string paintColor, int maxSpeed, int seatCapacity);