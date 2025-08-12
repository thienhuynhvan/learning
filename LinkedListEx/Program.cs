public class Program
{
    static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>();
        list.AddFirst("A");
        list.AddLast("C");
        list.AddFirst("B");
        // b a c
        LinkedListNode<string>? nodeA = list.Find("A");
        list.AddAfter(nodeA, "D");
        // b a d c
        Console.WriteLine("List:");
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
        list.Remove("D");
        list.RemoveFirst();
        list.RemoveLast();
        Console.WriteLine("After Remove:");
        foreach (string s in list)
        {
            Console.WriteLine(s);
        }

    }
}