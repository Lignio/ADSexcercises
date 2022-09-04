namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void consoleCheck()
    {
        //Arrange
        var program = new Program();

        //Act
        //var check = program.main(); 
        var result = Program.isLeapYear(1684);
        var result1 = Program.isLeapYear(1600);
        var result2 = Program.isLeapYear(1587);
        var result3 = Program.isLeapYear(1500);

    

        //Assert
        //var output = writer.GetStringBuilder().ToString().TrimEnd();
        //output.Should().Be("Want to know if a specific year is a leapyear or not?");
        result.Should().Be(true);
        result1.Should().Be(true);
        result2.Should().Be(false);
        result3.Should().Be(false);
    }
}