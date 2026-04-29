namespace Lab7;

public class Node
{
    public short Value { get; set; }
    public Node? Next { get; set; }

    public Node(short value)
    {
        Value = value;
        Next = null;
    }
}