internal class Program
{
    private static void Main(string[] args)
    {
        var myQueue = new MyQueue();
        myQueue.Push(1);
        myQueue.Push(2);
        myQueue.Push(3);
        myQueue.Push(4);
        var a = myQueue.Pop();
        myQueue.Push(5);
        var a2 = myQueue.Pop();
        var a3 = myQueue.Pop();
        var a4 = myQueue.Pop();
        var a5 = myQueue.Pop();
    }
}

public class MyQueue
{
    private Stack<int> _firstStack;
    private Stack<int> _secondStack;

    public MyQueue()
    {
        _firstStack = new Stack<int>();
        _secondStack = new Stack<int>();
    }

    public void Push(int x)
    {
        _firstStack.Push(x);
    }

    public int Pop()
    {
        var firstStackToList = _firstStack.ToList();
        firstStackToList.Reverse();

        var returnedFirstStackValue = firstStackToList.First();

        firstStackToList.Remove(firstStackToList.First());
        foreach (var item in firstStackToList)
        {
            _secondStack.Push(item);
        }

        _firstStack.Clear();

        var secondStackToList = _secondStack.ToList();
        secondStackToList.Reverse();
        foreach (var item in secondStackToList)
        {
            _firstStack.Push(item);
        }

        _secondStack.Clear();
        return returnedFirstStackValue;
    }

    public int Peek()
    {
        var firstStackToList = _firstStack.ToList();
        firstStackToList.Reverse();
        return firstStackToList.First();
    }

    public bool Empty()
    {
        return _firstStack.Count == 0;
    }
}
