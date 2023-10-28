var path = NormalizePath("/etc/./..//code//./");
Console.ReadLine();

string NormalizePath(string path)
{
    if (string.IsNullOrEmpty(path))
        return string.Empty;

    var arr = path.Split('/').Where(x=>!string.IsNullOrEmpty(x)).ToArray();
    var stack = new Stack<string>();
    stack.Push(arr.First());
    
    for (int i = 1; i < arr.Length; i++)
    {
        switch (arr[i])
        {
            case ".":
                continue;
            case "..":
                if (stack.Any() && !string.IsNullOrEmpty(stack?.Peek()))
                {
                    stack.Pop();
                }
                continue;
            default:
                stack.Push(arr[i]);
                break;
        }
    }

    var normPath = string.Join("/", stack.ToArray().Reverse());
    return normPath;
}
