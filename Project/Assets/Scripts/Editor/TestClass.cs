using System;
using System.Threading;
using UnityEngine;
using NUnit.Framework;

[TestFixture]
[Category("Test Example")]
public class TestClass
{
	[Test]
	public void PassingTest()
	{
		int value = Mathf.Abs(-1);

		Assert.That(value >= 0);
	}

	[Test]
	public void FailingTest()
	{
		float value = Mathf.Sqrt(-1);

		Assert.That(value > 0);
	}

	[Test]
	[Ignore("Ignored test")]
	public void IgnoredTest()
	{
		throw new Exception("Ignore this test");
	}

	[Test]
	[MaxTime(100)]
	public void SlowTest()
	{
		Thread.Sleep(200);
	}

	[Test]
	[ExpectedException(typeof(ArgumentException), ExpectedMessage = "expected message")]
	public void ExpectedExceptionTest()
	{
		throw new ArgumentException("expected message");
	}
}
