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
        private double alfa; // угол раствора конуса 

        public void SetFunction(double _alfa, double _sigma)
        {
            sigma = _sigma;
            alfa = _alfa;
        }

        public double FunctionValue(double x, double u)
        {
            double res = -0.6*sigma*(Math.Sqrt(2*g))*
                (1.0/Math.Pow(Math.Tan(0.5*alfa), 2))*(1.0/Math.PI)*(1.0/Math.Pow(u, 1.5));
            return res;
        }
    }
}
