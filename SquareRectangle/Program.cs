public abstract class Shape
{
    public abstract double CalculateArea();
    public override string ToString() => $"Area: {CalculateArea()}";
}
public class Rectangle : Shape
{
    private double _width;
    private double _height;
    public Rectangle(double width, double height)
    {
       this._width = width;
       this._height = height;
    }
    public override double CalculateArea()
    {
        return this._width * this._height;
    }
    public override string ToString()
    {
        return $"Rectangle: {_width} * {_height} = {CalculateArea()}";
    }
}
public class Square : Rectangle
{
    public Square(double side) : base(side, side) { }
    public override string ToString()
    {
        return $"Area Square = {CalculateArea()}";
    }
}

public class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("Calculating area of a rectangle/ square");
            Console.Write("Choose an option: 1 for rectangle, 2 for square, 0 for exit: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter width: ");
                    double width;
                    while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
                    {
                        Console.Write("Enter Valid Width(> 0): ");
                    }                
                    Console.Write("Enter height: ");
                    double height;
                    while (!double.TryParse(Console.ReadLine(), out height) || height <= 0)
                    {
                        Console.Write("Enter Valid Height(> 0): ");
                    } 
                    Shape rectangle = new Rectangle(width, height);
                    Console.WriteLine(rectangle.ToString());
                    break;
                case "2":
                    Console.Write("Enter side: ");
                    double side;
                    while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
                    {
                        Console.Write("Enter Valid Side(> 0): ");
                    }                
                    Shape square = new Square(side);
                    Console.WriteLine(square.ToString());
                    break;
                case "0":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    continue;
            }
        }
    }
}