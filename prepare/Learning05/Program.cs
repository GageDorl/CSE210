using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = [];

        Square s = new("Red", 2);
        shapeList.Add(s);

        Rectangle r = new("Yellow", 2, 3);
        shapeList.Add(r);

        Circle c = new("Blue", 2);
        shapeList.Add(c);

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}