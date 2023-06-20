namespace Pares.Pares.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Class1.EsPar(2));
        Assert.False(Class1.EsPar(1));
    }
}