using System;
using System.Security.Cryptography.X509Certificates;

public class Circle : Shapes
{
   private double _radius;

   public Circle(double radius)
   {
        _radius = radius;
   }

    public override double GetArea()
    {
       return _radius * _radius * Math.PI;
    }
}