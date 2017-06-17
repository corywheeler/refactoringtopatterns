﻿using NUnit.Framework;
using System;
using ReplaceConstructorsWithCreationMethods.InitialCode;

namespace RefactoringToPatterns.ReplaceConstructorsWithCreationMethods.InitialCode
{
    [TestFixture]
    public class CapitalCalculationTests
    {
        private readonly DateTime? _maturity = new DateTime(2020, 10, 2);
        private readonly DateTime? _expiry = new DateTime(2021, 10, 2);

        private const double Commitment = 3.0;
        private const double Outstanding = 12.9;
        private RiskAdjustedCapitalStrategy _riskAdjustedCapitalStrategy = 
            new RiskAdjustedCapitalStrategy();
        const int RiskRating = 5;

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

        [Test]
        public void TestRevolverLoanNoPayments()
        {
            Loan loan = new Loan(Commitment, RiskRating, null, _expiry);
            Assert.IsInstanceOf(typeof(CapitalStrategyRevolver), loan.CapitalStrategy);
        }

        [Test]
        public void TestRCTLLoanOnePayment()
        {
            Loan loan = new Loan(Commitment, Outstanding, RiskRating, _maturity, _expiry);
            Assert.IsInstanceOf(typeof(CapitalStrategyRCTL), loan.CapitalStrategy);
        }

        [Test]
        public void TestTermLoanWithRiskAdjustedCapitalStrategy() {
            Loan loan = new Loan(_riskAdjustedCapitalStrategy, 
                                 Commitment, Outstanding, RiskRating, 
                                 _maturity, null);
            
            Assert.IsInstanceOf(typeof(RiskAdjustedCapitalStrategy), loan.CapitalStrategy);
        }
    }
}