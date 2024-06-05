namespace Loops;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void WhileTestMethod()
    {
        int number = 0;

        while (number < 10)
        {
            Console.WriteLine(number);
            number++;
        }
    }

    [TestMethod]
    public void ForTestMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                continue; // Skip the rest of the loop when i is 5
            }

            Console.WriteLine(i);

            if (i == 8)
            {
                break; // Exit the loop when i is 8
            }
        }
    }

    [TestMethod]
    public void DoWhileTestMethod()
    {
        int number = 0;

        do
        {
            if (number == 3)
            {
                number++;
                continue; // Skip the rest of the loop when number is 3
            }

            Console.WriteLine(number);
            number++;
        }
        while (number < 10);
    }

    [TestMethod]
    public void SwitchTestMethod()
    {
        int number = 0;

        while (number < 10)
        {
            switch (number)
            {
                case 3:
                    Console.WriteLine("Three");
                    break; // Exit the switch statement when number is 3

                case 5:
                    number++;
                    continue; // Skip the rest of the loop when number is 5

                case 8:
                    Console.WriteLine("Eight");
                    break; // Exit the switch statement when number is 8

                default:
                    Console.WriteLine(number);
                    break; // Continue with the loop after this case
            }

            number++;
        }
    }
}