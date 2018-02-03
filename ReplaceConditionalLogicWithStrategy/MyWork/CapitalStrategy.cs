using System;
namespace ReplaceConditionalLogicWithStrategy.MyWork
{
    public abstract class CapitalStrategy
    {

        private long MILLIS_PER_DAY = 86400000;
        private long DAYS_PER_YEAR = 365;

        public abstract double Capital(Loan loan);

        protected double RiskFactorFor(Loan loan)
        {
            return InitialCode.RiskFactor.GetFactors().ForRating(loan.GetRiskRating());
        }

        private double UnusedRiskFactorFor(Loan loan)
        {
            return UnusedRiskFactors.GetFactors().ForRating(loan.GetRiskRating());
        }

        public virtual double Duration(Loan loan)
        {
            if (loan.GetExpiry() == null && loan.GetMaturity() != null)
            {
                return WeightedAverageDuration(loan);
            }
            else if (loan.GetExpiry() != null && loan.GetMaturity() == null)
            {
                return YearsTo(loan.GetExpiry(), loan);
            }
            return 0.0;
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

        protected double YearsTo(DateTime? endDate, Loan loan)
        {
            DateTime? beginDate = (loan.GetToday() == null ? loan.GetStart() : loan.GetToday());
            return (double)((endDate?.Ticks - beginDate?.Ticks) / MILLIS_PER_DAY / DAYS_PER_YEAR);
        }
    }
}
