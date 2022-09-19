using System.Reflection.Emit;

namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public static void Execute6ShouldReturn8()
    {
        var res =  Fib.RunAsync(new[] { "6" });
        Assert.Equal(8,res[0]);
    }
}