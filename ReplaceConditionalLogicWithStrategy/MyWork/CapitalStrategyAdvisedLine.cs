namespace ReplaceConditionalLogicWithStrategy.MyWork
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.GetCommitment() * loan.GetUnusedPercentage() * Duration(loan) * RiskFactorFor(loan);
        }
    }
}
