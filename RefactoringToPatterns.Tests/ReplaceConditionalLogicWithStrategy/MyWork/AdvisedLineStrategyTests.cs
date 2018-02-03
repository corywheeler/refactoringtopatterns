using NUnit.Framework;
using System;
using ReplaceConditionalLogicWithStrategy.MyWork;

namespace RefactoringToPatterns.ReplaceConditionalLogicWithStrategy.MyWork
{
    [TestFixture()]
    public class AdvisedLineStrategyTests
    {
        private readonly int LOW_RISK_TAKING = 2;
        private readonly double LOAN_AMOUNT = 10000.00;
        private readonly double TWO_DIGIT_PRECISION = 0.001;

        [Test()]
        public void calculates_duration_of_a_loan()
        {
            var revolverStrategy = new CapitalStrategyAdvisedLine();
            DateTime start = November(20, 2003);
            DateTime maturity = November(20, 2006);
            DateTime expiry = November(20, 2007);

            Loan revolverLoan = Loan.NewAdvisedLine(LOAN_AMOUNT, start, expiry, LOW_RISK_TAKING);
            Assert.AreEqual(40027, revolverStrategy.Duration(revolverLoan), TWO_DIGIT_PRECISION);

        }

        private static DateTime November(int dayOfMonth, int year)
        {
            return new DateTime(year, 11, dayOfMonth);
        }
    }
}
