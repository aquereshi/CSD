namespace Mob
{
    [TestClass]
    public sealed class NumberGeneratorSpecs
    {
        [TestMethod]
        public void EvenNumber()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number %  2 == 0);
        }

        [TestMethod]
        public void EndwithTwo()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number % 10 == 2);
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
        public void SumOfBothDigitsEqualSix()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue((number % 10) + (number / 10) == 6);
        }


    }
}
