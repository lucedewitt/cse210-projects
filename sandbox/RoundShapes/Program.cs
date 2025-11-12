using System.Runtime.InteropServices;

namespace RoundShapes;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        List<RoundShape> myShapes = new List<RoundShape>();
        myShapes.Add(new Circle(1.0));
        myShapes.Add(new Cylinder(1.0, 2.0));
        foreach (RoundShape r in myShapes) {
            Console.WriteLine(r.Area());
        }
    }
}
