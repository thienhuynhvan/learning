public abstract class Shape
{
    public abstract double CalculateArea();
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
        return $"Rectangle Area: {this._width}x{this._height} = {CalculateArea()}";
    }
}
public class Square : Shape
{
    private double _side;
    public Square(double side)
    {
        _side = side;
    }
    public override double CalculateArea()
    {
        return _side * _side;
    }
    public override string ToString()
    {
        return $"Square Area: {this._side}x{this._side} = {CalculateArea()}";
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
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice)&&( choice !=1 && choice != 2 && choice != 0))
            { 
                Console.Write("Choose a right option: 1 for rectangle, 2 for square, 0 for exit: ");
            }
            Shape shape = null;
            switch (choice)
            {
                case 1:
                    Console.Write("Enter width and height (separated by space): ");
                    string recInput = Console.ReadLine()?.Trim();
                    string[] recInputs = recInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (recInputs.Length == 2 &&
                        double.TryParse(recInputs[0], out double width) && width > 0 &&
                        double.TryParse(recInputs[1], out double height) && height > 0)
                    {
                        shape = new Rectangle(width, height);
                    }
                    else
                    {
                        Console.Write("Invalid Side!");
                    }
                    break;
                case 2:
                    Console.Write("Enter side: ");
                    string sideInput=Console.ReadLine()?.Trim();
                    if (double.TryParse(sideInput, out double side) && side > 0)
                    {
                        shape = new Square(side);
                    }
                    else
                    {
                        Console.Write("Invalid Side!");
                    }
                    break;
                case 0:
                    Console.WriteLine("Exiting program.");
                    return;
            }
            
            if (shape != null)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine();
        }
    }
}