﻿using NUnit.Framework;
using System;
//using Temp;
using ReplaceConstructorsWithCreationMethods;

namespace RefactoringToPatterns.Tests.ReplaceConstructorsWithCreationMethods
{
    [TestFixture]
    public class CapitalCalculationTests
    {
		private const double commitment = 3.0;
		private const int riskRating = 5;
        DateTime maturity = DateTime.MinValue;

        [SetUp]
		public void Init()
		{
            
		}

        [Test]
        public void GiveMeAGoodName()
        {
            Assert.IsInstanceOf(typeof(CapitalStrategyRevolver), new Loan(commitment, riskRating, maturity));
        }
    }
}
