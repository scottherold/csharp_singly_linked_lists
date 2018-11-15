using System;
using System.Collections.Generic;

namespace singlyLinkedLists
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList()
        {
            Head = null;
        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public void Add(int value)
        {
            SllNode newNode = new SllNode(value);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                SllNode runner = Head;
                while(runner.Next != null)
                {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public void Remove()
        {
            {
                SllNode runner = Head;
                SllNode prevNode = Head;
                while(runner.Next != null)
                {
                    prevNode = runner;
                    runner = runner.Next;
                }
                prevNode.Next = null;
            }
        }
        public void PrintValues()
        {
            SllNode runner = Head;
            while(runner.Next != null)
            {
                Console.WriteLine($"{runner.Value}");
                runner = runner.Next;
            }
            if(runner.Next == null)
            {
                Console.WriteLine($"{runner.Value}");
            }
        }
        public string Find(int findVal)
        {
            SllNode runner = Head;
            int counter = 0;
            while(runner.Next != null)
            {
                if(runner.Value == findVal)
                {
                    Console.WriteLine($"Node {counter} holds the value {runner.Value}");
                    return counter.ToString();
                }
                else
                {
                    runner = runner.Next;
                    counter ++;
                }
            }
            if(runner.Next == null && runner.Value == findVal)
            {
                Console.WriteLine($"Node {counter} holds the value {runner.Value}");
                return counter.ToString();
            }
            else
            {
                Console.WriteLine("Could not find node with requested value");
                return "Could not find node with requested value";
            }
        }
        public void RemoveAt(int remVal)
        {
            SllNode runner = Head;
            SllNode prevNode = Head;
            SllNode nextNode = Head;
            int counter = 0;
            while(runner.Next != null)
            {
                if(remVal == 0)
                {
                    Head = runner.Next;
                    return;
                }
                else if(remVal == counter +1)
                {
                    prevNode = runner;
                    runner = runner.Next;
                    nextNode = runner.Next;
                    prevNode.Next = nextNode;
                    return;
                }
                else
                {
                    runner = runner.Next;
                    counter ++;
                }
            }
            Console.WriteLine($"There is no node at location {remVal}");
        }
    }
}