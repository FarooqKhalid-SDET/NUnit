using NUnit.Framework;
using System;

namespace TestAdvanceOption.Tests;

public class AdvanceOptions
{
    [Test]
    public void UsingWarnings()
    {
        var isProcessed = false;
        Warn.Unless(isProcessed,Is.EqualTo(true).After(1).Minutes.PollEvery(10).Seconds);
        Console.WriteLine("Still going");
    }

    [Test]
    public void AssertPassThrowsException()
    {
        Assert.That(Assert.Pass, Throws.TypeOf<AssertionException>());
    }

    [Test]
    public void Assumptions()
    {
        Assume.That("a value", Is.EqualTo("this value"));
    }

    [Test]
    public void WillThisMakeItThroughCodeReview()
    {
        Assert.Multiple(() =>
        {
            Assert.AreEqual(1, 2);
            Assert.AreEqual(1, 3);
        });
    }
}