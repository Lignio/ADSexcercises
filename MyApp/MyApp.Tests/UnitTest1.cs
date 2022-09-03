namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void checkIfLeapYear()
    {
        //Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

        //Act
        var program = Assembly.Load(nameof(Program));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        //Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("True");
    }
}