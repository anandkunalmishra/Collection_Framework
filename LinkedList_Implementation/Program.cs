namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation
            LinkedList<string> linklist = new LinkedList<string>();

            //insert
            linklist.AddLast("three");
            linklist.AddFirst("one");

            //iterate
            LinkedListNode<string>? node = linklist.Find("three");

            if (node != null)
            {
                linklist.AddBefore(node,"two");
                linklist.AddAfter(node, "four");
            }
            else
            {
                Console.WriteLine("Node not found");
            }


            //print
            foreach(var item in linklist)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();


        }
    }
}
