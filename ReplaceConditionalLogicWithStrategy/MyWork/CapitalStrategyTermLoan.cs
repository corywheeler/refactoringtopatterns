using System;
namespace ReplaceConditionalLogicWithStrategy.MyWork
{
    public class CapitalStrategyTermLoan: CapitalStrategy
    {
        public override double Capital(Loan loan) 
        {
            return loan.GetCommitment() * Duration(loan) * RiskFactorFor(loan);
        }

        public override double Duration(Loan loan) 
        {
            return WeightedAverageDuration(loan);
        }

        private double WeightedAverageDuration(Loan loan)
        {
            double duration = 0.0;
            double weightedAverage = 0.0;
            double sumOfPayments = 0.0;

            foreach (var payment in loan.Payments())
            {
                sumOfPayments += payment.Amount;
                weightedAverage += YearsTo(payment.Date, loan) * payment.Amount;
            }

            if (loan.GetCommitment() != 0.0)
            {
                duration = weightedAverage / sumOfPayments;
            }

            return duration;
        }
    }
}
