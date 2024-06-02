namespace ElseIfs
{
    [TestClass]
    public class UnitTest1
    {
        private static int num1 = 200;
        private static int num2 = 400;

        [ClassInitialize]
        public static void InitializeNumbers(TestContext context)
        {
            // No need to assign values to static variables within ClassInitialize
            // They are already initialized to the declared values
        }

        [TestMethod]
        public void TestNumberComparison()
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("200 is greater than 400");
            }
            else
            {
                Console.WriteLine("200 is less than 400");
            }
        }
    }
}