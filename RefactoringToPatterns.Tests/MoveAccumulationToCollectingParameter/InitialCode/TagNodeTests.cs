using System;
using MoveAccumulationToCollectingParameter.InitialCode;
using NUnit.Framework;

namespace RefactoringToPatterns.Tests.MoveAccumulationToCollectingParameter.InitialCode
{
    [TestFixture]
    public class TagNodeTests
    {
        private TagNode _tagNode;

        [SetUp]
        public void Context()
        {
            _tagNode = new TagNode("parent", "gender='female'");
        }
        
        [Test]
        public void Should_Give_A_String_Representation()
        {
            var expected = "<parent gender='female'></parent>";
            
            Assert.AreEqual(expected, _tagNode.ToString());
        }
    }
}