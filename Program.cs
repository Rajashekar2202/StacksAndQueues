namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {

            DequeueElements dequeue = new DequeueElements();
            dequeue.Enqueue(56);
            dequeue.Enqueue(30);
            dequeue.Enqueue(70);
            dequeue.Display();
            while (!dequeue.IsEmpty())
            {
                dequeue.Dequeue();
            }
        }
    }
}