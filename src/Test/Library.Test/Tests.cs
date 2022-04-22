using NUnit.Framework;
using DateFormat;

namespace Library.Test;

public class Tests
{

    [Test]
    public void Test1()
    {
        string dia = "10/11/1977";
        string actual = Program.ChangeFormat(dia);
        string expected = "1977-11-10";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test2()
    {
        string dia = "05/12/2001";
        string actual = Program.ChangeFormat(dia);
        string expected = "2001-12-05";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test3()
    {
        string dia = "00/00/";
        string actual = Program.ChangeFormat(dia);
        string expected = "-00-00";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test4()
    {

        Assert.Pass();
    }

    [Test]
    public void Test5()
    {
        Assert.Pass();
    }

}
