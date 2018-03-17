using NUnit.Framework;
using System;
using FormTemplateMethod.MyWork;

namespace RefactoringToPatterns.FormTemplateMethod.MyWork
{
    [TestFixture()]
    public class AdvisedLineStrategyTests
    {
        private readonly int LOW_RISK_TAKING = 2;
        private readonly double LOAN_AMOUNT = 10000.00;
        private readonly double TWO_DIGIT_PRECISION = 0.001;

        [Test()]
        public void test_advised_line_loan_same_payments()
        {
            var advisedLineStrategy = new CapitalStrategyAdvisedLine();
            DateTime start = November(20, 2003);
            DateTime maturity = November(20, 2006);
            DateTime expiry = November(20, 2007);

            Loan advisedLineLoan = Loan.NewAdvisedLine(LOAN_AMOUNT, start, expiry, LOW_RISK_TAKING);
            advisedLineLoan.Payment(1000.00, November(20, 2004));
            advisedLineLoan.Payment(1000.00, November(20, 2005));
            advisedLineLoan.Payment(1000.00, November(20, 2006));

            Assert.AreEqual(40027, advisedLineStrategy.Duration(advisedLineLoan), TWO_DIGIT_PRECISION);
            Assert.AreEqual(1200810, advisedLineStrategy.Capital(advisedLineLoan), TWO_DIGIT_PRECISION);
        }

        private static DateTime November(int dayOfMonth, int year)
        {
            return new DateTime(year, 11, dayOfMonth);
        }
    }
}