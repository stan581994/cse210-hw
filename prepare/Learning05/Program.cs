using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("black",8);
        Rectangle rectangle = new Rectangle("black",8,6);
        Circle circle = new Circle("black",8);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            Console.WriteLine($"Color: {shape.GetColor()} | Area: {shape.GetArea()}");
        }
    }
}