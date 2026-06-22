namespace Mob
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void isEvenNumber()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number %  2 == 0);
        }

        [TestMethod]
        public void IsNumberEndwithTwo()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number % 10 == 2);
        }


        [TestMethod]
        public void isNumberGreaterThanNine()
        {
            //Arrange
            NumberGenerator numberGenerator = new NumberGenerator();

            //Act
            int number = numberGenerator.Generate();

            //Assert
            Assert.IsTrue(number > 9);
        }

    }
}
