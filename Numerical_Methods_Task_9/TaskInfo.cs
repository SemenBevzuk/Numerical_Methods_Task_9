using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Task_9
{
    class TaskInfo
    {
        public int Number { get; private set; }
        public double Alfa { get; private set; }
        public double Sigma { get; private set; }
        public double X0 { get; private set; }
        public double U0 { get; private set; }
        public double h0 { get; private set; }
        public double e { get; private set; }
        public int Max_iteration { get; private set; }


        public TaskInfo(int _number, double _alfa, double _sigma, double _x0, double _u0, double _h0, double _e,
            int _maxIteration)
        {
            Number = _number;
            Alfa = _alfa;
            Sigma = _sigma;
            X0 = _x0;
            U0 = _u0;
            h0 = _h0;
            e = _e;
            Max_iteration = _maxIteration;
        }
    }
}
