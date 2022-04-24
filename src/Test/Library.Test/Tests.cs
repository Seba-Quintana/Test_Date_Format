using NUnit.Framework;
using DateFormat;

namespace Library.Test;

public class Tests
{

    // Los test se deben correr desde Test_Date_Format

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
        string dia = "";
        string? actual = Program.ChangeFormat2(dia, "");
        string expected = "";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test5()
    {
        string dia = "11/10/2002";
        string? actual = Program.ChangeFormat2(dia, "DD-MM-YYYY");
        string expected = "11-10-2002";
        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void Test6()
    {
        string dia = "11/10/2002";
        string? actual = Program.ChangeFormat2(dia, "DD-YYYY-MM");
        string expected = "11-2002-10";
        Assert.AreEqual(expected, actual);
    }

        [Test]
    public void Test7()
    {
        string dia = "11/10/2002";
        string? actual = Program.ChangeFormat2(dia, "MM-DD-YYYY");
        string expected = "10-11-2002";
        Assert.AreEqual(expected, actual);
    }

        [Test]
    public void Test8()
    {
        string dia = "11/10/2002";
        string? actual = Program.ChangeFormat2(dia, "MM-YYYY-DD");
        string expected = "10-2002-11";
        Assert.AreEqual(expected, actual);
    }

        [Test]
    public void Test9()
    {
        string dia = "11/10/2002";
        string? actual = Program.ChangeFormat2(dia, "YYYY-DD-MM");
        string expected = "2002-11-10";
        Assert.AreEqual(expected, actual);
    }

        [Test]
    public void Test10()
    {
        string dia = "11/10/2002";
        string? actual = Program.ChangeFormat2(dia, "YYYY-MM-DD");
        string expected = "2002-10-11";
        Assert.AreEqual(expected, actual);
    }
}
