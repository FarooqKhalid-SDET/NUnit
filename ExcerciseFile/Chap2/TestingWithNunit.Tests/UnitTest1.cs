using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace TestingWithNunit.Tests;

public class MyFirstNUnitTests
{
    [Test]
    public async Task IAMDoingGreat()
    {
        Console.WriteLine("See you in the test output!");
        Assert.True(true);
    }

    [Test]
    public static void ThisIsAStaticTest()
    {

    }
}