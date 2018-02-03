using System;
using NUnit.Framework;
using ReplaceConditionalLogicWithStrategy.MyWork;
namespace RefactoringToPatterns.ReplaceConditionalLogicWithStrategy.MyWork
{
    [TestFixture()]
    public class CapitalStrategyTests
    {
        private readonly int HIGH_RISK_TAKING = 5;
        private readonly double LOAN_AMOUNT = 10000.00;
        private readonly double TWO_DIGIT_PRECISION = 0.001;

        [Test()]
        public void calculates_duration_of_a_loan()
        {
            var revolverStrategy = new CapitalStrategyRevolver();
            DateTime start = November(20, 2003);
            DateTime expiry = November(20, 2007);

            Loan revolver = Loan.NewRevolver(LOAN_AMOUNT, start, expiry, HIGH_RISK_TAKING);
            Assert.AreEqual(40027, revolverStrategy.Duration(revolver), TWO_DIGIT_PRECISION);

        }

        private static DateTime November(int dayOfMonth, int year)
        {
            return new DateTime(year, 11, dayOfMonth);
        }
    }
}
