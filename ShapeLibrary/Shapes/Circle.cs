﻿using ShapeLibrary.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be greater than zero.");
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
