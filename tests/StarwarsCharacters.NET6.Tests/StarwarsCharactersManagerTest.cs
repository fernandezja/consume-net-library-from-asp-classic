using Xunit;

namespace StarwarsCharacters.NET6.Tests { 

    public class StarwarsCharactersManagerTest
{
    [Fact]
    public void GetRandom_Test()
    {
        var sut = new StarwarsCharactersManager();
        var result = sut.GetRandom();

        Assert.NotNull(result);

    }

    [Theory]
    [InlineData(1, "Anakin Skywalker")]
    [InlineData(6, "Yoda")]
    public void Get_WithData_Test(int id, string nameExpected)
    {
        var sut = new StarwarsCharactersManager();
        var result = sut.Get(id);

        Assert.NotNull(result);
        Assert.Equal(id, result.Id);
        Assert.Equal(nameExpected, result.Name);

    }


    [Fact]
    public void Get_WithoutData_Test()
    {
        var sut = new StarwarsCharactersManager();
        var result = sut.Get(0);

        Assert.Null(result);

    }

    [Fact]
    public void GetInfo_Test()
    {
        var sut = new StarwarsCharactersManager();
        var result = sut.GetInfo();

        Assert.Equal("StarwarsCharacters (NET 6) version 1.6.0.0", result);

    }
    }
}