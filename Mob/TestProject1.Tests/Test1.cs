namespace TestProject1.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void FalseIsTrue()
        {

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TrueIsTrue()
        {

            Assert.IsTrue(true);
        }
    }
}
