namespace UnitTestBasics
{
    [TestClass]
    public class UnitTest1
    {
        private int someNumber;
        private string word;

        [TestInitialize]
        public void TestInitialize()
        {
            someNumber = 10;
            word = "testing";
        }

        [TestMethod]
        [Description("This test checks two numbers for equality")]
        public void Integers_Are_Equal()
        {
            Assert.AreEqual(someNumber, 10, "These numbers are not equal");
        }

        [TestMethod]
        public void Integers_Are_Not_Equal()
        {
            Assert.AreNotEqual(someNumber, 15);
        }

        [TestMethod]
        public void String_Ends_With()
        {
            StringAssert.EndsWith(word, "ing", "This test only passes if the given string ends in ing");
        }
    }
}