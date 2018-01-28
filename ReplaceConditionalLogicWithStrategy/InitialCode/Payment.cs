using System;

namespace ReplaceConditionalLogicWithStrategy.InitialCode
{
    public class Payment
    {
        private readonly double _amount;
        private readonly DateTime _date;
        private DateTime paymentDate;

        public Payment()
        {
            _amount = 0.0;
            _date = new DateTime();
        }

        public Payment(double amount, DateTime date)
        {
            Amount = amount;
            Date = paymentDate;
        }

        public double Amount
        {
            get
            {
                return _amount;
            }

            private set { }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            private set { }
        }
    }
}