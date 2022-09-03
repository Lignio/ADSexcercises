

namespace MyApp.Tests{

public class LeapYearTests

{
    [Fact]
    public void isThisALeapYear()
    {
        // Arrange
        var year = new Leapyear();

        // Act
        var result = year.isLeapYear(1684);
        var result1 = year.isLeapYear(1600);
        var result2 = year.isLeapYear(1587);
        var result3 = year.isLeapYear(1500);

        // Assert
        result.Should().Be(true);
        result1.Should().Be(true);
        result2.Should().Be(false);
        result3.Should().Be(false);
    }
}
}