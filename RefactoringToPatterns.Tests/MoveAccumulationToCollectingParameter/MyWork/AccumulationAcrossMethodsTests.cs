using System;
using System.Text;
using NUnit.Framework;

/*
* On page 315 Joshua makes the statement that Java's String would not allow you to accumulate results across methods.
* I was pretty sure of what he meant, and was also pretty certain that was the case with C# as well... but I wanted to
* check it so I wrote this small test class to explore that.
* 
* I've left a failing test in here, Accumulate_With_String_Does_Not_Work_Across_Method_Calls. This shows that passing
* a String into a method, and then seemingly mutating that string inside of that method... does not mutate the original
* String passed in.
*
* This is not the case with the second test that uses a StringBuilder,
* Accumulate_With_StringBuilder_Does_Work_Accross_Method_Calls.
*
* This shows the difference in how these types are passed. You may say... of course! I wanted to leave this behind
* for anyone that hit that part of the book and maybe didn't have an understanding of what Joshua was talking about.
*/

namespace RefactoringToPatterns.Tests.MoveAccumulationToCollectingParameter.MyWork
{
    [TestFixture]
    public class AccumulationAcrossMethodsTests
    {

        [Test]
        public void Accumulate_With_String_Does_Not_Work_Across_Method_Calls()
        {
            string expectedFullName = "Cory Wheeler";
            string notMyFullName = "Cory";
            
            AccumulateWithString(notMyFullName);
            
            Assert.AreNotEqual(expectedFullName, notMyFullName);
        }

        [Test]
        public void Accumulate_With_StringBuilder_Does_Work_Accross_Method_Calls()
        {
            string expectedFullName = "Cory Wheeler";
            StringBuilder myFullName = new StringBuilder("Cory");
            
            AccumulateWithStringBuffer(myFullName);
            
            Assert.AreEqual(expectedFullName, myFullName.ToString());
        }

        public void AccumulateWithString(string accumulator)
        {
            accumulator += " " + "Wheeler";
            
            Console.WriteLine(accumulator);
        }

        public void AccumulateWithStringBuffer(StringBuilder accumulator)
        {
            accumulator.Append(" ");
            accumulator.Append("Wheeler");
            
            Console.WriteLine(accumulator);
        }
    }
}