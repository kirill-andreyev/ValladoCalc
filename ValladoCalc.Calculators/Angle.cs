using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValladoCalc.Calculators
{
    public static class Angle
    {
        public static decimal ConvertToDegrees(decimal radians)
        {
            return radians * 180m / (decimal)Math.PI;
        }

        public static decimal ConvertToRadians(decimal degrees)
        {
            return degrees * ((decimal)Math.PI / 180m);
        }
    }
}
