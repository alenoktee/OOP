using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Entities;

public class Rectangle : Shape
{
    public override string Name => "Rectangle";
    private double Length { get; set; }
    private double Width { get; set; }
    public Rectangle(double length, double width)
    {
        if (length <= 0 || width <= 0)
        {
            throw new ArgumentException("Sides must be greater than zero.");
        }

        Length = length;
        Width = width;
    }
    public override double CalculateArea()
    {
        return Length * Width;
    }
}
