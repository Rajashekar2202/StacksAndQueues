namespace StackAndQueue
{
    class Program
    {
        public static void Main(string[] args)
        {

            PeakAndPopStack peakAndPopStack = new PeakAndPopStack();
            peakAndPopStack.Push(56);
            peakAndPopStack.Push(30);
            peakAndPopStack.Push(70);
            peakAndPopStack.Display();
            while (!peakAndPopStack.IsEmpty())
            {
                peakAndPopStack.Peek();
                peakAndPopStack.Pop();
            }
        }
    }
}