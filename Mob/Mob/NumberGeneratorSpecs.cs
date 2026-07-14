namespace Mob
{
    [TestClass]
    public sealed class NumberGeneratorSpecs
    {
        [TestMethod]
        public void EvenNumber()
        {          
            var numberGenerator = new NumberGenerator();
                 
            int number = numberGenerator.Generate();
                    
            Assert.IsTrue(number %  2 == 0);
        }

        [TestMethod]
        public void EndsInTwo()
        {
            //Arrange 
            var numberGenerator = new NumberGenerator();

            //Act 
            int number = numberGenerator.Generate();

            //Assert 
            Assert.IsTrue(number.ToString().EndsWith("2"));
        }

        [TestMethod]
        public void GreaterThan9()
        {
            //Arrange 
            var numberGenerator = new NumberGenerator();

            //Act 
            int number = numberGenerator.Generate();

            //Assert 
            Assert.IsTrue(number > 9);
        }

        [TestMethod]
        public void Lessthan100()
        {
            //Arrange 
            var numberGenerator = new NumberGenerator();

            //Act 
            int number = numberGenerator.Generate();

            //Assert 
            Assert.IsTrue(number < 100);
        }

        [TestMethod]
        public void SumOfBothDigitsEquals6()
        {
            //Arrange 
            var numberGenerator = new NumberGenerator();

            //Act 
            int number = numberGenerator.Generate();
            int firstDigit = number/10 ;
            int secondDigit = number % 10;

            //Assert 
            Assert.IsTrue(firstDigit + secondDigit == 6);
        }
    }
}
