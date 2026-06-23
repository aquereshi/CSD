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
            Assert.AreEqual(0, number % 2);
        }

        [TestMethod]
        public void EndwithTwo()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.AreEqual(2, number % 10);
        }


        [TestMethod]
        public void GreaterThan9()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsGreaterThan(9, number);
        }


        [TestMethod]
        public void LessThan100()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsLessThan(100, number);
        }

        [TestMethod]
        public void SumOfBothDigitsEqualSix()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.AreEqual(6, (number % 10) + (number / 10));
        }
    }
}
