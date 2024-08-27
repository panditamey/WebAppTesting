namespace WebAppTesting
{
    public class CalculatorTest
    {
        Calculator calculator;
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        public CalculatorTest() { 
            calculator = new Calculator();
        }

        [Fact]
        public void AddsTwoValue()
        {
            //Arrange
            int x = 10;
            int y = 20;
            int expected = x + y;
            //Act
            int actual = calculator.Add(x,y);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractsTwoValue()
        {
            //Arrange
            int x = 20;
            int y = 10;
            int expected = x - y;
            //Act
            int actual = calculator.Substract(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}