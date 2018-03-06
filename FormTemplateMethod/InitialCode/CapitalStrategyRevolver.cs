namespace FormTemplateMethod.InitialCode
{
    public class CapitalStrategyRevolver : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return (loan.OutstandingRiskAmount() * Duration(loan) * RiskFactorFor(loan))
                        + (loan.UnusedRiskAmount() * Duration(loan) * UnusedRiskFactorFor(loan));
        }

        private double UnusedRiskFactorFor(Loan loan)
        {
            return UnusedRiskFactors.GetFactors().ForRating(loan.GetRiskRating());
        }
    }
}