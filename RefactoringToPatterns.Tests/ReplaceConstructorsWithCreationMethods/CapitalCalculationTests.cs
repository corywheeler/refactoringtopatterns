﻿using NUnit.Framework;
using System;
 using ReplaceConstructorsWithCreationMethods.InitialCode;

namespace RefactoringToPatterns.Tests.ReplaceConstructorsWithCreationMethods
{
    [TestFixture]
    public class CapitalCalculationTests
    {
        private const double Commitment = 3.0;
        private const int RiskRating = 5;
        private readonly DateTime? _maturity = new DateTime(2020, 10, 2);

        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void TestTermLoanNoPayments()
        {
            Loan loan = new Loan(Commitment, RiskRating, _maturity);
            Assert.IsInstanceOf(typeof(CapitalStrategyTermLoan), loan.CapitalStrategy);
        }

        [Test]
        public void TestTermLoanOnePayment()
        {
            Loan loan = new Loan(Commitment, RiskRating, _maturity);
            Assert.IsInstanceOf(typeof(CapitalStrategyTermLoan), loan.CapitalStrategy);
        }
    }
}
