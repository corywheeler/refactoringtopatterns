using System;
namespace FormTemplateMethod.MyWork
{
    public class CapitalStrategyTermLoan : CapitalStrategy
    {
        private readonly double EPSILON = 0.001;

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

            if (Math.Abs(loan.GetCommitment()) > EPSILON)
            {
                duration = weightedAverage / sumOfPayments;
            }

            return duration;
        }
    }
}