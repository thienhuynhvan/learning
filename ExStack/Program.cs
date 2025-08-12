class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        stack.Push("A");
        stack.Push("B");
        stack.Push("C");

        Console.WriteLine("Phần tử trên cùng: " + stack.Peek()); // C

        Console.WriteLine("Lấy ra: " + stack.Pop()); // C
        Console.WriteLine("Lấy ra: " + stack.Pop()); // B

        Console.WriteLine("Còn lại trong stack:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}