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
        private readonly double TWO_DIGIT_PRECISION = 0.001;

        [SetUp]
        public void Init() {

        }

        [Test()]
        public void test_term_loan_same_payments()
        {
            DateTime start = November(20, 2003);
            DateTime maturity = November(20, 2006);

			Loan termLoan = Loan.NewTermLoan(LOAN_AMOUNT, start, maturity, HIGH_RISK_TAKING);
            termLoan.Payment(1000.00, November(20, 2004));
            termLoan.Payment(1000.00, November(20, 2005));
            termLoan.Payment(1000.00, November(20, 2006));

            Assert.Multiple(() => {
                Assert.AreEqual(20027, termLoan.Duration(), TWO_DIGIT_PRECISION);
                Assert.AreEqual(6008100, termLoan.Capital(), TWO_DIGIT_PRECISION);
            });
        }

        [Test()]
        public void test_revolver_loan_same_payments()
        {
            DateTime start = November(20, 2003);
            DateTime maturity = November(20, 2006);
            DateTime expiry = November(20, 2007);

            Loan termLoan = Loan.NewRevolver(LOAN_AMOUNT, start, expiry, maturity, HIGH_RISK_TAKING);
            termLoan.Payment(1000.00, November(20, 2004));
            termLoan.Payment(1000.00, November(20, 2005));
            termLoan.Payment(1000.00, November(20, 2006));

            Assert.Multiple(() => {
                Assert.AreEqual(40027, termLoan.Duration(), TWO_DIGIT_PRECISION);
                Assert.AreEqual(4002700, termLoan.Capital(), TWO_DIGIT_PRECISION);
            });
        }

        private static DateTime November(int dayOfMonth, int year)
        {
            return new DateTime(year, 11, dayOfMonth);
        }
    }
}