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
        var result4 = Program.parseUserInput("1200");
        var result5 = Program.parseUserInput("text");
       


    

        //Assert
        result.Should().Be(true);
        result1.Should().Be(true);
        result2.Should().Be(false);
        result3.Should().Be(false);
        result4.Should().Be(true);
        result5.Should().Be(false);

        
        
    }
}
