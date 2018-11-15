using System;
using System.Collections.Generic;

namespace singlyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList newList = new SinglyLinkedList();
            newList.Add(8);
            newList.Add(3);
            newList.Add(4);
            newList.PrintValues();
            newList.Find(4);
            newList.RemoveAt(2);
            newList.PrintValues();
            newList.Add(6);
            newList.PrintValues();
        }
    }
}
