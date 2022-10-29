namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {

            QueueLinkedList queue = new QueueLinkedList();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

        }
    }
}