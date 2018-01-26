using System;

namespace ReplaceConditionalLogicWithStrategy.InitialCode
{
    public class UnusedRiskFactors
    {
        private UnusedRiskFactors() {

        }

        public static UnusedRiskFactors GetFactors()
        {
            return new UnusedRiskFactors();
        }

        public double ForRating(double riskRating)
        {
            return 1.0;
        }
    }
}