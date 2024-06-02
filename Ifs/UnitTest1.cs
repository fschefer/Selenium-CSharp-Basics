namespace Conditions
{
    [TestClass]
    public class UnitTest1
    {
        private static int num1;
        private static int num2;

        [ClassInitialize]
        public static void NumberAssignation(TestContext context)
        {
            num1 = 200;
            num2 = 400;
        }
    
        [TestMethod]
        public void AreNumbersEqual()
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are indeed equal");
                Assert.IsTrue(true); // Assertion to mark the test as passed
            }
            else
            {
                Assert.Fail("The numbers are not equal"); // Assertion to mark the test as failed
            }
        }

        [TestMethod]
        public void AreNumbersDifferent()
        {
            if (num1 != num2)
            {
                Console.WriteLine("The numbers are different");
                Assert.IsTrue(true); // Assertion to mark the test as passed
            }
            else
            {
                Assert.Fail("The numbers are equal"); // Assertion to mark the test as failed
            }
        }

        [TestMethod]
        public void Is200GreaterThan400()
        {
            if (num1 > num2)
            {
                Console.WriteLine("200 is greater");
                Assert.IsTrue(true); // Assertion to mark the test as passed
            }
            else
            {
                Assert.Fail("200 is not greater than 400"); // Assertion to mark the test as failed
            }
        }

        [TestMethod]
        public void Is200LessThan400()
        {
            if (num1 < num2)
            {
                Console.WriteLine("200 is less");
                Assert.IsTrue(true); // Assertion to mark the test as passed
            }
            else
            {
                Assert.Fail("200 is not less than 400"); // Assertion to mark the test as failed
            }
        }

        [TestMethod]
        public void Is200LessThanOrEqualTo400()
        {
            if (num1 <= num2)
            {
                Console.WriteLine("200 is less than or equal to 400");
                Assert.IsTrue(true); // Assertion to mark the test as passed
            }
            else
            {
                Assert.Fail("200 is not less than or equal to 400"); // Assertion to mark the test as failed
            }
        }

        [TestMethod]
        public void Is200GreaterThanOrEqualTo400()
        {
            if (num1 >= num2)
            {
                Console.WriteLine("200 is greater than or equal to 400");
                Assert.IsTrue(true); // Assertion to mark the test as passed
            }
            else
            {
                Assert.Fail("200 is not greater than or equal to 400"); // Assertion to mark the test as failed
            }
        }
    }
}
