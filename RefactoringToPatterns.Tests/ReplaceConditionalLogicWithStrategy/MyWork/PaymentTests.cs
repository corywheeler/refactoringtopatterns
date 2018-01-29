using NUnit.Framework;
using System;
using ReplaceConditionalLogicWithStrategy.MyWork;

namespace RefactoringToPatterns.ReplaceConditionalLogicWithStrategy.MyWork
{
    [TestFixture()]
    public class PaymentTests
    {
        private Payment _payment;
        private DateTime _christmasDay;

        [SetUp]
        public void Init()
        {
            _christmasDay = new DateTime(2010, 12, 25);
            _payment = new Payment(1000.0, _christmasDay);
        }

        [Test()]
        public void payment_is_constructed_correctly()
        {
            
            Assert.Multiple(() => {
                Assert.AreEqual(1000, _payment.Amount);
                Assert.AreEqual(_christmasDay, _payment.Date);
            });

        }
    }
}
