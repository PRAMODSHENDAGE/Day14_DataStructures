// See https://aka.ms/new-console-template for more information

using QueueUsingLinkedList;

Console.WriteLine("Program For Queue Using Linked List");

LinkedListQueue linkedListQueue = new LinkedListQueue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Peek();

linkedListQueue.Dequeue();
linkedListQueue.IsEmpty();



