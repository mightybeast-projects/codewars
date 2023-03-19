namespace codewars.Modules.Practice.MyStack;

public class MyStack
{
    public bool isEmpty { get; private set; } = true;
    public int size { get; private set; }
    private int[] array;
    private int lastPushedElement;

    public MyStack() => array = new int[10];

    public void Push(int item)
    {
        lastPushedElement = item;
        array[size] = item;
        size++;

        isEmpty = false;
    }

    public int Pop() => array[--size];
}