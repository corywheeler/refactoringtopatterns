namespace ReplaceConditionalLogicWithStrategy.MyWork
{
    public class CapitalStrategyRevolver : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return (loan.OutstandingRiskAmount() * loan.Duration() * RiskFactorFor(loan))
                        + (loan.UnusedRiskAmount() * loan.Duration() * UnusedRiskFactorFor(loan));
        }

        private double UnusedRiskFactorFor(Loan loan)
        {
            return UnusedRiskFactors.GetFactors().ForRating(loan.GetRiskRating());
        }
    }
}
