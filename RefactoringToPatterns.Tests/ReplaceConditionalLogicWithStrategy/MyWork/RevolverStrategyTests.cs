using System;
using NUnit.Framework;
using ReplaceConditionalLogicWithStrategy.MyWork;

namespace RefactoringToPatterns.ReplaceConditionalLogicWithStrategy.MyWork
{
    [TestFixture()]
    public class RevolverStrategyTests
    {
        private readonly int HIGH_RISK_TAKING = 5;
        private readonly double LOAN_AMOUNT = 10000.00;
        private readonly double TWO_DIGIT_PRECISION = 0.001;

        [Test()]
        public void test_revolver_loan_same_payments()
        {
            var revolverStrategy = new CapitalStrategyRevolver();
            DateTime start = November(20, 2003);
            DateTime expiry = November(20, 2007);

            Loan revolverLoan = Loan.NewRevolver(LOAN_AMOUNT, start, expiry, HIGH_RISK_TAKING);
            revolverLoan.Payment(1000.00, November(20, 2004));
            revolverLoan.Payment(1000.00, November(20, 2005));
            revolverLoan.Payment(1000.00, November(20, 2006));

            Assert.Multiple(() => {
				Assert.AreEqual(40027, revolverStrategy.Duration(revolverLoan), TWO_DIGIT_PRECISION);
				Assert.AreEqual(4002700, revolverStrategy.Capital(revolverLoan), TWO_DIGIT_PRECISION);
            });
        }

        private static DateTime November(int dayOfMonth, int year)
        {
            return new DateTime(year, 11, dayOfMonth);
        }
    }
}
