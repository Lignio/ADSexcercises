

namespace MyApp.Tests{

public class LeapYearTests

{
    [Fact]
    public void isThisALeapYear()
    {
        // Arrange
        var test = new Leapyear();

        // Act
        var result = test.isLeapYear(1684);
        var result1 = test.isLeapYear(1600);
        var result2 = test.isLeapYear(1587);
        var result3 = test.isLeapYear(1500);

        // Assert
        result.Should().Be(true);
        result1.Should().Be(true);
        result2.Should().Be(false);
        result3.Should().Be(false);
    }
}
}