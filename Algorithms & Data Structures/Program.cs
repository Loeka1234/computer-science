using System;
using System.Collections.Generic;
using AlgorithmsAndDataStructures.LinkedList;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var lnk = new SimpleLinkedList<string>();
            lnk.AddLast("one");
            lnk.AddLast("two");
            lnk.AddLast("3");
            lnk.AddFirst("first");
            lnk.ReadAll();
        }
    }
}