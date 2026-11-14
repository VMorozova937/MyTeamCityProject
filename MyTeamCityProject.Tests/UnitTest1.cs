namespace MyTeamCityProject.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var programType = typeof(Program);
        Assert.NotNull(programType);
    }
}
