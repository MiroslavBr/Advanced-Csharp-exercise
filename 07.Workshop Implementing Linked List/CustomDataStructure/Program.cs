using System;
using System.Collections.Generic;
using System.Linq;
using CustomDataStructure;
using static CustomDataStructure.DoublyLinkedList;

namespace CustomDoublyLinkedList
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddLast(5);

            list.RemoveFirst();
            list.RemoveLast();
           
            list.ForEach(x => Console.WriteLine(x));

            int[] nums = list.ToArray();
            nums =nums.Select(x => x += 1).ToArray();
            Console.WriteLine(string.Join(", ", nums)); 

        } 

        
    }
}
