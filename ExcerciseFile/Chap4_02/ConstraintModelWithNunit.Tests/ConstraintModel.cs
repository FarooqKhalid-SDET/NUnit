using NUnit.Framework;

namespace ConstraintModelWithNunit.Tests;

public class ConstraintModel
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AreEqual()
    {
        Assert.That("actual", Is.EqualTo("expected"));
    }

    [Test]
    public void AreEqualWithDescription()
    {
        Assert.That("actual", Is.EqualTo("expected"), "What does this even mean");
    }

    [Test]
    public void AreEqualWithDynamicDescription()
    {
        Assert.That("actual", Is.EqualTo("expected"), "what does {0} mean to {1}", "testing", "you");
    }

    [Test]
    public void AreNotEqual()
    {
        Assert.That("actual", Is.Not.EqualTo("expected"));
    }

    [Test]
    public void ContainsOneInstanceOfThree() 
    {
        int[] arrayOfValues = new int[] { 1, 2, 4 };

        Assert.That(arrayOfValues, Has.Exactly(1).EqualTo(3));
    }

    [Test]
    public void IsMoreThanFiveAndLessThan100()
    {
        var testValue = 100;
        Assert.That(testValue, Is.GreaterThan(5).Or.LessThan(100));
    }
}