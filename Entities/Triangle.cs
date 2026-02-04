using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Entities;

public class Triangle : Shape
{
    public override string Name => "Triangle";
    private double SideA { get; set; }
    private double SideB { get; set; }
    private double SideC { get; set; }
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Sides must be greater than zero.");
        }

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
        {
            throw new ArgumentException("A triangle with such sides does not exist.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    public override double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }
}
