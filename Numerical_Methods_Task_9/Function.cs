using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Task_9
{
    class Function // du/dx = Function()
    {
        private double sigma; // площадь отверстия для слива 
        private const double g = 9.81;
        private double alfa; // угол раствора конуса радианы

        public void SetFunction(double _alfa, double _sigma)
        {
            sigma = _sigma;
            alfa = (_alfa * Math.PI) / 180.0;
        }

        public double FunctionValue(double x, double v)
        {
            if (v <= 0)
                return 0;
            double c1 = -0.6 * Math.Sqrt(2 * g) * (1.0 / Math.PI);
            double c2 = sigma / Math.Pow(Math.Tan(0.5 * alfa), 2);
            double c3 = 1.0 / Math.Sqrt(Math.Pow(v, 3));
            double res = c1*c2*c3;
            return res;
        }
    }
}
