using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CustomDataStructure
{
    public class DoublyLinkedList
    {
        public class ListNode
        {
            public int Value { get; set; }
            public ListNode Next { get; set; }
            public ListNode Previous { get; set; }
            public ListNode(int value)
            {
                this.Value = value;
            }
        }

        public ListNode Head { get; set; }
        public ListNode Tail { get; set; }

        public int Count { get; private set; }


        public void AddFirst(int value)
        {
            ListNode newHead = new(value);
            if (this.Head == null)
            {
                this.Head = newHead;
                this.Tail = newHead;
                Count++;
                return;

            }

            newHead.Next = this.Head;
            this.Head.Previous = newHead;
            this.Head = newHead;
            Count++;
        }
        public void AddLast(int value)
        {
            ListNode newTail = new(value);

            if (this.Tail == null)
            {
                this.Head = newTail;
                this.Tail = newTail;
                Count++;

                return;
            }

            this.Tail.Next = newTail;
            newTail.Previous = this.Tail;
            this.Tail = newTail;
            Count++;
        }
        public int RemoveFirst()
        {
            if (this.Count==0)
            {
                throw new InvalidOperationException("This list is empty");
            }


            int valueOfRemovedElement = this.Head.Value;
            this.Head = this.Head.Next;

            if (this.Head == null)
            {
                this.Tail = null;
            }
            else
            {
                this.Head.Previous = null;
            }
            Count--;
            return valueOfRemovedElement;
        }
        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("This list is empty");
            }

            int valueOfRemovedElement = this.Tail.Value;
            this.Tail = this.Tail.Previous;

            if(this.Tail == null)
            {
                this.Head = null;
            } else
            {
                this.Tail.Next = null;
            }

            Count--;
            return valueOfRemovedElement;
        }

        public void ForEach(Action<int> action)
        {
            ListNode currentNode = this.Head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            ListNode currentNode = this.Head;
            for (int i = 0; i < this.Count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return array;
        }
    }
}
