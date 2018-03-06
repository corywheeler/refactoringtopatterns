namespace FormTemplateMethod.InitialCode
{
    public class UnusedRiskFactors
    {
        private UnusedRiskFactors()
        {

        }

        public static UnusedRiskFactors GetFactors()
        {
            return new UnusedRiskFactors();
        }

        public double ForRating(double riskRating)
        {
            return 0.01;
        }
    }
}
