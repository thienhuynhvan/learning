
class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        Console.WriteLine("Phần tử đầu: " + queue.Peek()); // A

        Console.WriteLine("Lấy ra: " + queue.Dequeue()); // A
        Console.WriteLine("Lấy ra: " + queue.Dequeue()); // B

        Console.WriteLine("Còn lại trong queue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}