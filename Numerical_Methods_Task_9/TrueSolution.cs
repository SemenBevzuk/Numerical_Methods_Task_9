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

        public TrueSolution(double _alfa, double _sigma, double _u0)
        {
            sigma = _sigma;
            alfa = (_alfa*Math.PI)/180.0;;
            u0 = _u0;
        }

        public double FunctionValue(double x)
        {
            double c1 = -0.6*(Math.Sqrt(2*g)/Math.PI)*(sigma/Math.Pow(Math.Tan(0.5*alfa),2.0));
            double c2 = (2.0/5.0)*Math.Pow(u0,5.0/2.0);
            double c3 = (5.0/2.0)*(c1*x+c2);
            double c4 = Math.Pow(c3, 2.0);
            double c5 = Math.Pow(c4, 1.0/5.0);
            return c5;
        }
        private double RightPoint()
        {
            double c1 = Math.Pow(u0, 5.0/2.0)*Math.PI*Math.Pow(Math.Tan(alfa/2.0), 2);
            double c2 = sigma*Math.Sqrt(2*g)*1.5;
            return c1/c2;
        }
        public void FindPoints()
        {
            listOfPoints.Clear();
            int N = 200;
            double right_x = RightPoint();
            double h = right_x/N;
            double u = u0;
            double x = 0;
            listOfPoints.Add(new Point(x,u));
            while (u > 0.01)
            {
                x = x + h;
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
