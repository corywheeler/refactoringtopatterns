using NUnit.Framework;
using RefactoringToPatterns.ComposeMethod.MyWork;

namespace RefactoringToPatterns.ComposeMethod.MyWork
{
    [TestFixture()]
    public class ListTests
    {
        [Test()]
        public void it_tells_the_count_of_how_many_things_it_contains()
        {
            var list = new List();   
            list.add(new {});
            Assert.AreEqual(1, list.Count);
        }
    }
}
