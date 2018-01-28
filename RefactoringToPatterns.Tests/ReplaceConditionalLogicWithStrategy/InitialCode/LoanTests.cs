using System;
using NUnit.Framework;
using ReplaceConditionalLogicWithStrategy.InitialCode;

namespace RefactoringToPatterns.ReplaceConditionalLogicWithStrategy.InitialCode
{
    [TestFixture()]
    public class LoanTests
    {
        private readonly int HIGH_RISK_TAKING = 5;
        private readonly double LOAN_AMOUNT = 10000.00;
        private readonly double TWO_DIGIT_PRECISION = 0.1;

        [SetUp]
        public void Init() {

        }

        [Test()]
        public void TestTermLoanSamePayments()
        {
            DateTime start = November(20, 2003);
            DateTime maturity = November(20, 2006);

			Loan termLoan = Loan.NewTermLoan(LOAN_AMOUNT, start, maturity, HIGH_RISK_TAKING);
            termLoan.Payment(1000.00, November(20, 2004));
            termLoan.Payment(1000.00, November(20, 2005));
            termLoan.Payment(1000.00, November(20, 2006));

            Assert.AreEqual(2.0, termLoan.Duration(), TWO_DIGIT_PRECISION);
        }

        private static DateTime November(int dayOfMonth, int year)
        {
            return new DateTime(2003, 11, 20);
        }
    }
}