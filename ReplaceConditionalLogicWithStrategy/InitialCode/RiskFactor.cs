namespace ReplaceConditionalLogicWithStrategy.InitialCode
{
    public class RiskFactor
    {
        public static RiskFactor GetFactors()
        {
            return new RiskFactor();
        }

        public double ForRating(double riskRating)
        {
            return 1.0;
        }
    }
}