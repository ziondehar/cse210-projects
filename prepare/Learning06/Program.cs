using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shapes> shape = new List<Shapes>();

        Square s1 = new Square("Red", 14);
        shape.Add(s1);

        Rectangle s2 = new Rectangle("Orange", 4, 5);
        shape.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shape.Add(s3);

        foreach (Shapes s in shape)
        {
            
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }   
}