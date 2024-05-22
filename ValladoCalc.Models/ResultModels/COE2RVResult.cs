using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValladoCalc.Models.ResultModels
{
    public class COE2RVResult
    {
        public COE2RVResult()
        {
            RadiusVector = new decimal[3];
            SpeedVector = new decimal[3];
        }

        public decimal[] RadiusVector { get; set; }
        public decimal[] SpeedVector { get; set; }
    }
}
