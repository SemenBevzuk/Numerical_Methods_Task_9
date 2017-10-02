using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Numerical_Methods_Task_9
{
    internal class MetodInfo
    {
        public int Iteration { get; private set; }
        public double H { get; private set; }
        public double X { get; private set; }
        public double U { get; private set; }
        public double UHalf { get; private set; }
        public double DeltaU { get; private set; }
        public double S { get; private set; }
        public double e { get; private set; }
        public double UCorr { get; private set; }
        public double UResult { get; private set; }
        public int CountPlusH { get; private set; }
        public int CountMinusH { get; private set; }

        public MetodInfo(int _i, double _h, double _x, double _u, double _uHalf, double _deltaU, double _s,
            double _e, double _uCorr, double _uResult, int _countMinusH, int _countPlusH)
        {
            Iteration = _i;
            H = _h;
            X = _x;
            U = _u;
            UHalf = _uHalf;
            DeltaU = _deltaU;
            S = _s;
            e = _e;
            UCorr = _uCorr;
            UResult = _uResult;
            CountPlusH = _countPlusH;
            CountMinusH = _countMinusH;
        }
    }
}