using System;
using System.Collections.Generic;

namespace singlyLinkedLists
{
    public class SllNode
    {
        public int Value;
        public SllNode Next;
        public SllNode(int value)
        {
            // your code here
            Value = value;
            Next = null;
        }
    }
}