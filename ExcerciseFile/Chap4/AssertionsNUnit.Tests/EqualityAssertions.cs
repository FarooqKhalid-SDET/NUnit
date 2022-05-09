using NUnit.Framework;

namespace AssertionsNUnit.Tests;

public class EqualityAssertions
{
    [Test]
    public void AreEqual()
    {
        Assert.AreEqual("expected ", "actual");
    }

    [Test]
    public void AreEqualWithDescription()
    {
        Assert.AreEqual("expected", "actual", "What does this even mean");
    }

    [Test]
    public void AreEqualWithDynamicDescription()
    {
        Assert.AreEqual("expected", "actual", "What does {0} mean to {1}", "testing", "you");
    }

    [Test]
    public void AreEqualNumbers()
    {
        Assert.AreEqual(1, 2);
    }

    [Test]
    public void AreEqualNumbersWithDifferentType()
    {
        Assert.AreEqual(2, 2d);
    }

    [Test]
    public void AreEqualNumbersWithTolerance()
    {
        Assert.AreEqual(2, 2.3, .5);
    }

    [Test]
    public void AreEqualArrays()
    {
        var expected = new int[] { 1, 2, 3 };
        var actual = new int[] { 1, 3, 4 };
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void AreObjectEqual()
    {
        var Obj1=new object();
        var Obj2=new object();

        var areTheyEqual = Obj1.Equals(Obj2);
        Assert.IsTrue(areTheyEqual);
    }

    [Test]
    public void AreReferenceEqual()
    {
        var obj1 = new object();
        var obj2 = obj1;

        Assert.AreSame(obj1, obj2);
    }

    [Test]
    public void AreNotEqual()
    {
        Assert.AreNotEqual("expected", "actual");
    }

    [Test]
    public void IsStringEmpty()
    {
        var myString = "";
        Assert.IsEmpty(myString);
    }

    [Test]
    public void ComparingRelativeValues()
    {
        Assert.GreaterOrEqual(2, 3);
    }
}