internal class Program
{
    private static void Main(string[] args)
    {
        var recentCounter = new RecentCounter();
        recentCounter.Ping(1); // requests = [1], range is [-2999,1], return 1
        recentCounter.Ping(100); // requests = [1, 100], range is [-2900,100], return 2
        recentCounter.Ping(3001); // requests = [1, 100, 3001], range is [1,3001], return 3
        recentCounter.Ping(3002);
    }
}

public class RecentCounter
{
    private Queue<int> _queue;
    private List<int> _listRequestMilliseconds;
    
    public RecentCounter()
    {
        _queue = new Queue<int>();
        _listRequestMilliseconds = new();
    }
    
    public int Ping(int t)
    {
        _listRequestMilliseconds.Clear();
        _queue.Enqueue(t);
        
        foreach (var item in _queue.ToList())
        {
            if (item >= t - 3000)
            {
                _listRequestMilliseconds.Add(item);
            }
            else
            {
                _queue.Dequeue();
            }
        }
        
        return _listRequestMilliseconds.Count;
    }
}
