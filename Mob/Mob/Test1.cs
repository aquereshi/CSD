namespace Mob
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange = Pre Condition
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act = Steps
            int Number = numberGenerator.Generate();

            //Assert = Post Conditions
            Assert.IsTrue(Number %  2 == 0);
        }
    }
}
