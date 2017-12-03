using NUnit.Framework;
using PolymorphicCreationWithFactoryMethod.InitialCode;
namespace RefactoringToPatterns.PolymorphicCreationWithFactoryMethod.InitialCode
{
    [TestFixture()]
    public class DoesItWork
    {
        [Test()]
        public void TestCase()
        {
            var pcfm = new PleaseWork();
            Assert.AreEqual(pcfm.ItDoes, "It Does");
        }
    }
}