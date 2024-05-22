using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValladoCalc.Models.ResultModels;
using ValladoCalc.Models.ValueModels;

namespace ValladoCalc.Calculators
{
    public static class COE2RV
    {
        public static COE2RVResult Calculate(COE2RVModel data)
        {
            if(data.ArgumentOfPerigee == 0 && data.AscendingNode == 0)
            {
                data.TrueAnomaly = data.TrueLongitude;
            }
            else if(data.ArgumentOfPerigee == 0)
            {
                data.TrueAnomaly = data.ArgumentOfLatitude;
            }
            else if(data.AscendingNode == 0)
            {
                data.ArgumentOfPerigee = data.TrueLongitudeOfPerigee;
            }

            COE2RVResult result = new COE2RVResult();

            result.RadiusVector =
            [
                data.SemiParameter * (decimal)Math.Cos((double)data.TrueAnomaly) / (1 + data.Eccentricity * (decimal)Math.Cos((double)data.TrueAnomaly)),
                data.SemiParameter * (decimal)Math.Sin((double)data.TrueAnomaly) / (1 + data.Eccentricity * (decimal)Math.Cos((double)data.TrueAnomaly)),
                0m
            ];

            result.SpeedVector =
           [
                - (decimal)Math.Sqrt((double)(data.StandardGravitationalParameter / data.SemiParameter)) * (decimal)Math.Sin((double)data.TrueAnomaly),
                (decimal)Math.Sqrt((double)(data.StandardGravitationalParameter / data.SemiParameter)) * (data.Eccentricity + (decimal)Math.Cos((double)data.TrueAnomaly)),
                0
           ];

            decimal[,] transformationMatrix =
            {
                { 
                    (decimal)Math.Cos((double)data.AscendingNode) * (decimal)Math.Cos((double)data.ArgumentOfPerigee) - (decimal)Math.Sin((double)data.AscendingNode) * (decimal)Math.Sin((double)data.ArgumentOfPerigee) * (decimal)Math.Cos((double)data.Inclination), 
                    -(decimal)Math.Cos((double)data.AscendingNode) * (decimal)Math.Sin((double)data.ArgumentOfPerigee) - (decimal)Math.Sin((double)data.AscendingNode) * (decimal)Math.Cos((double)data.ArgumentOfPerigee) * (decimal)Math.Cos((double)data.Inclination),
                    (decimal)Math.Sin((double)data.AscendingNode) * (decimal)Math.Sin((double)data.Inclination)
                },
                {
                    (decimal)Math.Sin((double)data.AscendingNode) * (decimal)Math.Cos((double)data.ArgumentOfPerigee) + (decimal)Math.Cos((double)data.AscendingNode)*(decimal)Math.Sin((double)data.ArgumentOfPerigee)*(decimal)Math.Cos((double)data.Inclination),
                    -(decimal)Math.Sin((double)data.AscendingNode) * (decimal)Math.Sin((double)data.ArgumentOfPerigee) + (decimal)Math.Cos((double)data.AscendingNode) * (decimal)Math.Cos((double)data.ArgumentOfPerigee) * (decimal)Math.Cos((double)data.Inclination),
                    -(decimal)Math.Cos((double)data.AscendingNode) * (decimal)Math.Sin((double)data.Inclination)
                },
                {
                    (decimal)Math.Sin((double)data.ArgumentOfPerigee)*(decimal)Math.Sin((double)data.Inclination),
                    (decimal)Math.Cos((double)data.ArgumentOfPerigee) * (decimal)Math.Sin((double)data.Inclination),
                    (decimal)Math.Cos((double)data.Inclination)
                }
            };

            result.RadiusVector =
            [
                transformationMatrix[0,0] * result.RadiusVector[0] + transformationMatrix[0,1] * result.RadiusVector[1],
                transformationMatrix[1,0] * result.RadiusVector[0] + transformationMatrix[1,1] * result.RadiusVector[1],
                transformationMatrix[2,0] * result.RadiusVector[0] + transformationMatrix[2,1] * result.RadiusVector[1],
            ];

            result.SpeedVector =
            [
                transformationMatrix[0,0] * result.SpeedVector[0] + transformationMatrix[0,1] * result.SpeedVector[1],
                transformationMatrix[1,0] * result.SpeedVector[0] + transformationMatrix[1,1] * result.SpeedVector[1],
                transformationMatrix[2,0] * result.SpeedVector[0] + transformationMatrix[2,1] * result.SpeedVector[1],
            ];

            return result;
        }
    }
}
