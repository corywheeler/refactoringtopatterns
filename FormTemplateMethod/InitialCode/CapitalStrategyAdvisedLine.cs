namespace FormTemplateMethod.InitialCode
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return RiskAmountFor(loan) * base.Duration(loan) * RiskFactorFor(loan);
        }

        public override double RiskAmountFor(Loan loan)
        {
            return loan.GetCommitment() * loan.GetUnusedPercentage();
        }
    }
}