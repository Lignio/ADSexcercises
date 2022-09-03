

namespace MyApp.Tests{

public class CalculatorTests

{
    [Fact]
    public void isThisALeapYear()
    {
        // Arrange
        var sut = new Leapyear();

        // Act
        var result = sut.Add("1 2 3");

        // Assert
        result.Should().Be(6);
    }
}
}