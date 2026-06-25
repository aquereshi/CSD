namespace Mob
{
    [TestClass]
    public sealed class NumberGeneratorSpecs
    {
        [TestMethod]
        public void IsEven()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number % 2==0);           
        }

        [TestMethod]
        public void EndWith2()
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
        public void GreaterThan9()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();
            
            //Assert
            Assert.IsTrue(number > 9);

        }

        [TestMethod]
        public void LessThan100()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number < 100);
        }

        [TestMethod]
        public void SumOfBothDigitsIsSix()
        {
            //Arrange
            int number = new NumberGenerator().Generate();

            //Act
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            //Assert
            Assert.IsTrue( firstDigit + secondDigit == 6);
        }


    }
}
