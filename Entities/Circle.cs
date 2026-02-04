using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Entities;

public class Circle : Shape
{
    public override string Name => "Circle";
    private double Radius { get; set; }
    
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("The radius cannot be negative.");
        }
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
