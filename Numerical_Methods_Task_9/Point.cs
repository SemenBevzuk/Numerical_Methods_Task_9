﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Task_9
{
    class Point
    {
        public double X { get; private set; }
        public double U { get; private set; }

        public Point(double x, double u)
        {
            X = x;
            U = u;
        }
    }
}
