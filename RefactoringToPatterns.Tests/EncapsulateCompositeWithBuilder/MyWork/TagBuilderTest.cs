using NUnit.Framework;
using EncapsulateCompositeWithBuilder.MyWork;
using System;

namespace RefactoringToPatterns.EncapsulateCompositeWithBuilder.MyWork
{
    [TestFixture]
    public class TagBuilderTest
    {


        [Test]
        public void TestBuildOneNode()
        {
            string expectedXml = "<flavors/>";

            string actualXml = new TagBuilder("flavors").ToXml();

            Assert.AreEqual(expectedXml, actualXml);
        }

        [Test]
        public void TestBuildOneChild()
        {
            string expectedXml =
                "<flavors>" +
                  "<flavor/>" +
                "</flavors>";

            TagBuilder builder = new TagBuilder("flavors");
            builder.AddChild("flavor");
            string actualXml = builder.ToXml();

            Assert.AreEqual(expectedXml, actualXml);
        }

        [Test]
        public void TestBuildChildrenOfChildren()
        {
            string expectedXml =
                "<flavors>" +
                  "<flavor>" +
                    "<requirements>" +
                      "<requirement/>" +
                    "</requirements>" +
                  "</flavor>" +
                "</flavors>";

            TagBuilder builder = new TagBuilder("flavors");
            builder.AddChild("flavor");
            builder.AddChild("requirements");
            builder.AddChild("requirement");

            string actualXml = builder.ToXml();

            Assert.AreEqual(expectedXml, actualXml);
        }

        [Test]
        public void TestBuildSibling()
        {
            string expectedXml =
                "<flavors>" +
                  "<flavor1/>" +
                  "<flavor2/>" +
                "</flavors>";

            TagBuilder builder = new TagBuilder("flavors");
            builder.AddChild("flavor1");
            builder.AddSibling("flavor2");

            string actualXml = builder.ToXml();

            Assert.AreEqual(expectedXml, actualXml);


        }

        [Test]
        public void TestRepeatingChildrenAndGrandchildren()
        {
            string expectedXml =
                "<flavors>" +
                  "<flavor>" +
                    "<requirements>" +
                      "<requirement/>" +
                    "</requirements>" +
                  "</flavor>" +
                  "<flavor>" +
                    "<requirements>" +
                      "<requirement/>" +
                    "</requirements>" +
                  "</flavor>" +
                "</flavors>";

            TagBuilder builder = new TagBuilder("flavors");

            for (int i = 0; i < 2; i++)
            {
                builder.AddToParent("flavors", "flavor");
                builder.AddChild("requirements");
                builder.AddChild("requirement");
            }

            Assert.AreEqual(expectedXml, builder.ToXml());
        }

        [Test]
        public void TestParentNameNotFound()
        {
            TagBuilder builder = new TagBuilder("flavors");

            SystemException exception = Assert.Throws<SystemException>(() =>
            {
                for (int i = 0; i < 2; i++)
                {
                    builder.AddToParent("favors", "flavor");
                    builder.AddChild("requirements");
                    builder.AddChild("requirement");
                }
            });

            const string expectedErrorMessage = "missing parent tag: favors";
            Assert.AreEqual(expectedErrorMessage, exception.Message);
        }

        [Test]
        public void testAttributesAndValues()
        {
            string expectedXml =
                "<flavor name='Test-Driven Development'>" +
                    "<requirements>" +
                        "<requirement type='hardware'>" +
                            "1 computer for every 2 participants" +
                        "</requirement>" +
                        "<requirement type='software'>" +
                            "IDE" +
                        "</requirement>" +
                    "</requirements>" +
                "</flavor>";

            TagBuilder builder = new TagBuilder("flavor");
            builder.AddAttribute("name", "Test-Driven Development");
            builder.AddChild("requirements");
            builder.AddToParent("requirements", "requirement");
            builder.AddAttribute("type", "hardware");
            builder.AddValue("1 computer for every 2 participants");
            builder.AddToParent("requirements", "requirement");
            builder.AddAttribute("type", "software");
            builder.AddValue("IDE");

            Assert.AreEqual(expectedXml, builder.ToXml());
        }
    }
}
