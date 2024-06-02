namespace ClassLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int result = ClassLibrary1.Class1.AddNumbers(100, 100);
        Assert.AreEqual(200, result );
    }
}