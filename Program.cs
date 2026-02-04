using OOP.Entities;

public class Program
{
    private static void Main(string[] args)
    {
        CreateShapes();
    }

    private static void CreateShapes()
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5));
        shapes.Add(new Rectangle(4, 9));
        shapes.Add(new Triangle(3, 4, 5));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.Name} area: {shape.CalculateArea()}");
        }
    }
}