﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics_01
{
    class Circle
    {
        private double radius;

        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }

        public Circle(double newRadius)
        {
            radius = newRadius;
        }

        public double GetArea()
        {
            return Math.PI*radius*radius;
        }

        public double GetPerimeter()
        {
            return 2*Math.PI*radius;
        }

        public double GetDiameter()
        {
            return 2*radius;
        }
    }
}
