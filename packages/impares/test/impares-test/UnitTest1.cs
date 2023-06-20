namespace Impares.Impares.Test;


public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Class2.EsImPar(1));
        Assert.False(Class2.EsImPar(2));
    }
}