using NUnit.Framework;
using List = ComposeMethod.InitialCode.List;

namespace RefactoringToPatterns.ComposeMethod.InitialCode
{
    [TestFixture()]
    public class ListTests
    {
        [Test()]
        public void it_tells_the_count_of_how_many_things_it_contains()
        {
            var list = new List();   
            list.Add(new {});
            Assert.AreEqual(1, list.Count);
        }
    }
}
