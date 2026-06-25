namespace Mob
{
    [TestClass]
    public sealed class NumberGeneratorSpecs
    {
        [TestMethod]
        public void TestNumberIsEven()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();


            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number % 2==0);           
        }

        [TestMethod]
        public void TestNumberEndwihtTwo()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();


            //Act
            int number = numberGenerator.Generate();
            bool endingWithTwo = number.ToString().EndsWith('2');

            //Assert
            Assert.IsTrue(endingWithTwo);
            
        }

        [TestMethod]
        public void TestBigNumber()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();


            //Act
            int number = numberGenerator.Generate();
            

            //Assert
            Assert.IsTrue(number > 9);

        }

        [TestMethod]
        public void TestNumberLessthan100()
        {
            //Arrange

            //Act
            int number = new NumberGenerator().Generate();


            //Assert
            Assert.IsTrue(number < 100);

        }


    }
}
