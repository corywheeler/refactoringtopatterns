using System;
using System.Collections.Generic;

namespace ReplaceConditionalLogicWithStrategy.InitialCode
{
    public class Loan
    {
        double _commitment;
        private DateTime? _expiry;
        private DateTime? _maturity;
        private double _outstanding;
        IList<Payment> _payments;
        private readonly DateTime today = DateTime.Now;
        private readonly DateTime _start;
        private long MILLIS_PER_DAY = 86400000;
        private long DAYS_PER_YEAR = 365;
        private readonly double _riskRating;
        private double _loanAmount;

     

        public Loan(double loanAmount, DateTime start, DateTime maturity, int riskRating)
        {
            this._loanAmount = loanAmount;
            this._start = start;
            this._maturity = maturity;
            this._riskRating = riskRating;
        }

        public static Loan CreateTermLoan(double loanAmount, DateTime start, DateTime maturity, int riskRating)
        {
            return new Loan(loanAmount, start, maturity, riskRating);
        }

        public double Capital() {
            if(_expiry == null && _maturity != null)
                return _commitment * Duration() * RiskFactor();
            if(_expiry != null && _maturity == null) {
                if(GetUnusedPercentage() != 1.0) {
                    return _commitment * GetUnusedPercentage() * Duration() * RiskFactor();
                }
                else {
                    return (OutstandingRiskAmount() * Duration() * RiskFactor())
                        + (UnusedRiskAmount() * Duration() * UnusedRiskFactor());
                }
            }

            return 0.0;
        }

        private double Duration()
        {
            if (_expiry == null && _maturity != null)
            {
                return WeightedAverageDuration();
            }
            else if (_expiry != null && _maturity == null)
            {
                return YearsTo(_expiry);
            }
            return 0.0;
        }

        private double WeightedAverageDuration()
        {
            double duration = 0.0;
            double weightedAverage = 0.0;
            double sumOfPayments = 0.0;

            foreach (var payment in _payments)
            {
                sumOfPayments += payment.Amount;
                weightedAverage += YearsTo(payment.Date) * payment.Amount;
            }

            if (_commitment != 0.0)
            {
                duration = weightedAverage / sumOfPayments;
            }

            return duration;
        }

        private double YearsTo(DateTime? endDate)
        {
            DateTime beginDate = (today == null ? _start : today);
            return (double)((endDate?.Ticks - beginDate.Ticks) / MILLIS_PER_DAY / DAYS_PER_YEAR);
        }

        private double RiskFactor()
        {
            return InitialCode.RiskFactor.GetFactors().ForRating(_riskRating);
        }

        private double GetUnusedPercentage()
        {
            return 1.0;
        }

        private double UnusedRiskAmount()
        {
            return (_commitment - _outstanding);
        }

        private double UnusedRiskFactor()
        {
            return UnusedRiskFactors.GetFactors().ForRating(_riskRating);
        }

        private double OutstandingRiskAmount()
        {
            return _outstanding;
        }
    }
}