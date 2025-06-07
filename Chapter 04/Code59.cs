public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

public void Traverse(Node node)
{
    if (node == null)
        return;
    // Pre-order traversal: Node -> Left -> Right
    Console.WriteLine(node.Value);
    Traverse(node.Left);
    Traverse(node.Right);
}