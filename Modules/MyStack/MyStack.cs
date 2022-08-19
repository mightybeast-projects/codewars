namespace MyStack;

public class MyStack
{
    public int Size => _size;
    public bool IsEmpty => _isEmpty;

    private bool _isEmpty = true;
    private int[] _array;
    private int _size;
    private int _lastPushedElement;

    public MyStack()
    {
        _array = new int[10];
    }

    public void Push(int item)
    {
        _lastPushedElement = item;
        _array[_size] = item;
        _size++;

        _isEmpty = false;
    }

    public int Pop()
    {
        return _array[--_size];
    }
}