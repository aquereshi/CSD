namespace Mob
{
    [TestClass]
    public sealed class NumberGeneratorSpecs
    {
        [TestMethod]
        public void TestMethod()
        {
            //Arrange (Pre-Conditions)
            var numberGenerator = new NumberGenerator();

            //Act (Steps)
            int number = numberGenerator.Generate();

            //Assert (Post-Conditions)
            Assert.IsTrue(number %  2 == 0);
        }


    }
}
