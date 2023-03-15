using NUnit.Framework;

namespace MyStack;

[TestFixture]
public class Tests
{
    private MyStack stack;

    [Test]
    public void NewStackIsEmpty()
    {
        stack = new MyStack();

        Assert.IsTrue(stack.IsEmpty);
    }

    [Test]
    public void NewStackSizeEqualsZero()
    {
        stack = new MyStack();

        Assert.AreEqual(0, stack.Size);
    }

    [Test]
    public void StackIsNotEmptyWhenOneVariablePushed()
    {
        stack = new MyStack();

        stack.Push(1);

        Assert.IsFalse(stack.IsEmpty);
    }

    [Test]
    public void StackSizeEqualsOneAfterOnePush()
    {
        stack = new MyStack();

        stack.Push(1);

        Assert.AreEqual(1, stack.Size);
    }

    [Test]
    public void StackSizeEqualsOneAfterTwoPushOnePop()
    {
        stack = new MyStack();

        stack.Push(1);
        stack.Push(2);
        stack.Pop();

        Assert.AreEqual(1, stack.Size);
    }

    [Test]
    public void PushOnePopOneReturnsFirstElement()
    {
        stack = new MyStack();

        int element = 1;
        stack.Push(element);
        int popedElement = stack.Pop();

        Assert.AreEqual(element, popedElement);
    }

    [Test]
    public void PushTwoPopOneReturnLastInsertedValue()
    {
        stack = new MyStack();

        int element = 1;
        stack.Push(element);
        element = 2;
        stack.Push(element);
        int popedElement = stack.Pop();

        Assert.AreEqual(element, popedElement);
    }

    [Test]
    public void PushTwoPopTwoReturnFirstInsertedValue()
    {
        stack = new MyStack();
        int firstElement = 1;

        stack.Push(firstElement);
        stack.Push(2);

        stack.Pop();

        Assert.AreEqual(firstElement, stack.Pop());
    }

    [Test]
    public void StackSizeAfterTwoPushOnePopEqualsOne()
    {
        stack = new MyStack();

        stack.Push(1);
        stack.Push(1);
        stack.Pop();

        Assert.AreEqual(1, stack.Size);
    }

    [Test]
    public void PushThreePopTwoReturnSecondElement()
    {
        stack = new MyStack();
        int secondElement = 100;

        stack.Push(10);
        stack.Push(secondElement);
        stack.Push(1000);

        stack.Pop();

        Assert.AreEqual(secondElement, stack.Pop());
    }

    [Test]
    public void PushFivePopFiveReturnsFirstInsertedElements()
    {
        stack = new MyStack();
        int firstElement = 10;

        stack.Push(firstElement);
        stack.Push(100);
        stack.Push(1000);
        stack.Push(10000);
        stack.Push(100000);

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();

        Assert.AreEqual(firstElement, stack.Pop());
    }
}