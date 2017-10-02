using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace Numerical_Methods_Task_9
{
    class TrueSolution
    {
        private double sigma; // площадь отверстия для слива 
        private const double g = 9.81;
        private double alfa; // угол раствора конуса 
        private double u0; // начальная точка

        private readonly List<Point> listOfPoints = new List<Point>(); // список точек для графика

        public TrueSolution(double _alfa, double _sigma, double _u)
        {
            SetFunction(_alfa, _sigma, _u);
        }

        public void SetFunction(double _alfa, double _sigma, double _u0)
        {
            sigma = _sigma;
            alfa = _alfa;
            u0 = _u0;
        }

        public double FunctionValue(double x)
        {
            double c1 = -0.6*(1.0/Math.PI)*Math.Sqrt(2*g)*sigma*(1.0/Math.Pow(Math.Tan(alfa/2.0), 2));
            double c2 = c1*x + (2.0/5.0)*Math.Pow(u0, 5.0/2.0);
            double res = Math.Pow(2.5*c2, 2.0/5.0);
            return res;
        }

        public void FindPoints()
        {
            listOfPoints.Clear();
            double u = u0;
            double x = 0;
            listOfPoints.Add(new Point(x,u));
            while (u > 0)
            {
                x = x + 0.01;
                u = FunctionValue(x);
                listOfPoints.Add(new Point(x,u));
            }
        }
        public List<Point> GetPoints()
        {
            return listOfPoints;
        } 
    }
}
