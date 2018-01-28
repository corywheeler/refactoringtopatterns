using System;
using System.Collections.Generic;

namespace ReplaceConditionalLogicWithStrategy.InitialCode
{
    public class Loan
    {
        double _commitment = 1.0;
        private DateTime? _expiry;
        private DateTime? _maturity;
        private double _outstanding;
        IList<Payment> _payments = new List<Payment>();
        private DateTime? _today = DateTime.Now;
        private DateTime _start;
        private long MILLIS_PER_DAY = 86400000;
        private long DAYS_PER_YEAR = 365;
        private double _riskRating;
        private double _unusedPercentage;

        public Loan(double commitment, double notSureWhatThisIs, DateTime start, DateTime? expiry, DateTime? maturity, int riskRating)
        {
            this._expiry = expiry;
            this._commitment = commitment;
            this._today = null;
            this._start = start;
            this._maturity = maturity;
            this._riskRating = riskRating;
            this._unusedPercentage = 1.0;
        }

        public static Loan NewTermLoan(double commitment, DateTime start, DateTime maturity, int riskRating)
        {
            return new Loan(commitment, commitment, start, null, 
                            maturity, riskRating);
        }

        public static Loan NewRevolver(double commitment, DateTime start, DateTime expiry, int riskRating) 
        {
            return new Loan(commitment, 0, start, expiry,
                            null, riskRating);
        }

        public static Loan NewAdvisedLine(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            if (riskRating > 3) return null;
            Loan advisedLine = new Loan(commitment, 0, start, expiry,
                            null, riskRating);
            advisedLine.SetUnusedPercentage(0.1);
            return advisedLine;
        }

        public void Payment(double amount, DateTime paymentDate)
        {
            _payments.Add(new Payment(amount, paymentDate));
        }

        public double Capital() {
            if(_expiry == null && _maturity != null)
                return _commitment * Duration() * RiskFactor();
            if(_expiry != null && _maturity == null) {
                if(GetUnusedPercentage() != 1.0) {
                    // THIS IS FOR ADVISED LINE
                    return _commitment * GetUnusedPercentage() * Duration() * RiskFactor();
                }
                else {
                    // THIS IS FOR REVOLVER
                    return (OutstandingRiskAmount() * Duration() * RiskFactor())
                        + (UnusedRiskAmount() * Duration() * UnusedRiskFactor());
                }
            }

            return 0.0;
        }

        public double Duration()
        {
            if (_expiry == null && _maturity != null)
            {
                return WeightedAverageDuration();
            }
            else if (_expiry != null && _maturity == null)
            {
                // SHOULD HIT HERE FOR REVOLVER AND ADVISED LINE
                return YearsTo(_expiry);
            }
            return 0.0;
        }

        private double WeightedAverageDuration()
        { 
            // This is only used to calculate capital for a Term Loan.

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
            DateTime? beginDate = (_today == null ? _start : _today);
            return (double)((endDate?.Ticks - beginDate?.Ticks) / MILLIS_PER_DAY / DAYS_PER_YEAR);
        }

        private double RiskFactor()
        {
            return InitialCode.RiskFactor.GetFactors().ForRating(_riskRating);
        }

        private double GetUnusedPercentage()
        {
            return _unusedPercentage;
        }

        public void SetUnusedPercentage(double unusedPercentage) 
        {
            _unusedPercentage = unusedPercentage;
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