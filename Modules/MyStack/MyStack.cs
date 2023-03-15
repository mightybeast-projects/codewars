namespace MyStack;

public class MyStack
{
    public int Size => size;
    public bool IsEmpty => isEmpty;

    private bool isEmpty = true;
    private int[] array;
    private int size;
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