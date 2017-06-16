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
        readonly DateTime _maturity = DateTime.MinValue;

        [SetUp]
		public void Init()
		{
            
		}

        [Test]
        public void GiveMeAGoodName()
        {
            Assert.IsInstanceOf(typeof(CapitalStrategyRevolver), new Loan(Commitment, RiskRating, _maturity));
        }
    }
}
