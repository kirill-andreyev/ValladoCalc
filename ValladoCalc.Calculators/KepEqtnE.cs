﻿using ValladoCalc.Models;

namespace ValladoCalc.Calculators
{
    public static class KepEqtnE
    {
        public static KepEqtnEResult Calculate(KepEqtnEModel data)
        {
            decimal eccentricAnomaly;
            decimal eccentricAnomalyNext;

            if (data.AngleType == AngleDimension.Degrees)
            {
                data.MeanAnomality = data.MeanAnomality * ((decimal)Math.PI / 180m);
            }

            if (data.MeanAnomality > -(decimal)Math.PI && data.MeanAnomality < 0)
            {
                eccentricAnomalyNext = data.MeanAnomality - data.Eccentricity;
            }
            else if (data.MeanAnomality > (decimal)Math.PI)
            {
                eccentricAnomalyNext = data.MeanAnomality - data.Eccentricity;
            }
            else
            {
                eccentricAnomalyNext = data.MeanAnomality + data.Eccentricity;
            }

            do
            {
                eccentricAnomaly = eccentricAnomalyNext;
                eccentricAnomalyNext = eccentricAnomaly + ((data.MeanAnomality - eccentricAnomaly + data.Eccentricity * (decimal)Math.Sin((double)eccentricAnomaly)) / (1 - data.Eccentricity * (decimal)Math.Cos((double)eccentricAnomaly)));
            }
            while ((eccentricAnomalyNext - eccentricAnomaly) > data.Tolerance);

            return new KepEqtnEResult { EccentricAnomaly = eccentricAnomalyNext};
        }
    }
}
