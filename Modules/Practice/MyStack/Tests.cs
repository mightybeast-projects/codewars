using NUnit.Framework;

namespace MyStack;

[TestFixture]
public class Tests
{
    private MyStack stack;

    [SetUp]
    public void SetUp() => stack = new MyStack();

    [TestCase(ExpectedResult = true)]
    public bool NewStackIsEmpty() => stack.isEmpty;

    [TestCase(ExpectedResult = 0)]
    public int NewStackSizeEqualsZero() => stack.size;

    [Test]
    public void StackIsNotEmptyWhenOneVariablePushed()
    {
        stack.Push(1);

        Assert.IsFalse(stack.isEmpty);
    }

    [Test]
    public void StackSizeEqualsOneAfterOnePush()
    {
        stack.Push(1);

        Assert.AreEqual(1, stack.size);
    }

    [Test]
    public void StackSizeEqualsOneAfterTwoPushOnePop()
    {
        stack.Push(1);
        stack.Push(2);
        stack.Pop();

        Assert.AreEqual(1, stack.size);
    }

    [Test]
    public void PushOnePopOneReturnsFirstElement()
    {
        stack.Push(1);

        Assert.AreEqual(1, stack.Pop());
    }

    [Test]
    public void PushTwoPopOneReturnLastInsertedValue()
    {
        stack.Push(1);
        stack.Push(2);

        Assert.AreEqual(2, stack.Pop());
    }

    [Test]
    public void PushTwoPopTwoReturnFirstInsertedValue()
    {
        stack.Push(1);
        stack.Push(2);

        stack.Pop();

        Assert.AreEqual(1, stack.Pop());
    }

    [Test]
    public void StackSizeAfterTwoPushOnePopEqualsOne()
    {
        stack.Push(1);
        stack.Push(1);
        stack.Pop();

        Assert.AreEqual(1, stack.size);
    }

    [Test]
    public void PushThreePopTwoReturnSecondElement()
    {
        stack.Push(10);
        stack.Push(100);
        stack.Push(1000);

        stack.Pop();

        Assert.AreEqual(100, stack.Pop());
    }

    [Test]
    public void PushFivePopFiveReturnsFirstInsertedElements()
    {
        stack.Push(10);
        stack.Push(100);
        stack.Push(1000);
        stack.Push(10000);
        stack.Push(100000);

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();

        Assert.AreEqual(10, stack.Pop());
    }
}