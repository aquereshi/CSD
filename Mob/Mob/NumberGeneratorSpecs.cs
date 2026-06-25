namespace Mob
{
    [TestClass]
    public sealed class NumberGeneratorSpecs
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();


            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number % 2==0);
           
        }

     
    }
}
