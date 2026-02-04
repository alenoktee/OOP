using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Entities;

public abstract class Shape
{
    public abstract string Name { get; }
    public abstract double CalculateArea();
}
