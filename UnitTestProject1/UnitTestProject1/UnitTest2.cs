using System;
using NUnit.Framework;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestFixture()]
    public class CalculatorTests2
    {
        /*
        Write a function that takes in a string of one or more words, and returns the same string, but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
        */

        [Test()]
        public void Test1()
        {
            Assert.AreEqual("emocleW", Kata.SpinWords("Welcome"));
        }

        [Test()]
        public void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Kata.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.SpinWords("Just kidding there is still one more"));
        }
    }
}
