namespace CSharp_Example.Collections;

public class StackFunctions
{
    Stack<string> stack = new Stack<string>();

    /// <summary>
    /// Inserts an object at the top of the Stack
    /// </summary>
    public void Push(string input)
    {
        stack.Push(input);
    }

    /// <summary>
    /// Inserts an object at the top of the Stack
    /// </summary>
    public string Pop()
    {
        return stack.Pop();
    }
}
