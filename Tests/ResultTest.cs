using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int n = 5;
        string password = "2bbbb";

        var expected = 2;
        var actual = Result.minimumNumber(n,password);

        Assert.Equal(expected,actual);
    }

    [Fact]
    public void Test2()
    {
        int n = 5;
        string password = "2bb#A";

        var expected = 1;
        var actual = Result.minimumNumber(n,password);

        Assert.Equal(expected,actual);
    }
}