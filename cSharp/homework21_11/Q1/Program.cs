using System;
using System.Collections;

class Program
{
    public static void printList(SortedList list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine("{0} : {1} ", list.GetKey(i), list.GetByIndex(i));
        }
    }
    
    public static void Main()
    {
        SortedList myList = new SortedList();
        myList.Add(1, "Duc");
        myList.Add(2, "Long");
        myList.Add(3, "Minh");

        Console.WriteLine(myList[1]);
        Console.WriteLine(myList[2]);

        printList(myList);
        myList.Remove(1);
        printList(myList);
        myList.RemoveAt(1);
        printList(myList);
    }
}