using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();

        Shape test1 = new Square("red", 2);
        shapes.Add(test1);

        Shape test2 = new Rectangle("green", 2, 3);
        shapes.Add(test2);

        Shape test3 = new Circle("blue", 3);
        shapes.Add(test3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}