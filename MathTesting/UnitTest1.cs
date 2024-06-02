namespace MathTesting
{
    [TestClass]
    public class UnitTest1
    {
        private int num1;
        private int num2;

        [TestInitialize]
        public void AssigningNumbers()
        {
            num1 = 10;
            num2 = 20;
        }

        [TestMethod]
        public void AddingNumbers()
        {
            int sum = num1 + num2;
            Assert.AreEqual(30, sum);
        }

        [TestMethod]
        public void SubtractingNumbers()
        {
            int result = num2 - num1;
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void MultiplyingNumbers()
        {
            int product = num1 * num2;
            Assert.AreEqual(200, product);
        }

        [TestMethod]
        public void DividingNumbers()
        {
            int quotient = num2 / num1;
            Assert.AreEqual(2, quotient);
        }

        [TestMethod]
        public void Modules()
        {
            int remainder = num2 % num1;
            Assert.AreEqual(0, remainder);
        }
    }
}