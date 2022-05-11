// See https://aka.ms/new-console-template for more information
using LinkedListProgram;

Console.WriteLine("Program For Linked List");

LinkedList list = new LinkedList();

list.addFirst("70"); list.addFirst("30"); list.addFirst("56"); list.printlist();

list.InsertAtParticularPosition(1, "40"); list.printlist();

list.deleteLast("70"); list.printlist();  //this will delete the last node

list.deleteFirst("56"); list.printlist();  //this will delete the first node

list.Search("70"); list.printlist();