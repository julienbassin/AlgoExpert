using System.Collections.Generic;
using System;


public class Program
{
    // This is an input class. Do not edit.
    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
    {
        // Write your code here.

        LinkedList current = linkedList;
        LinkedList nextNode = null;

        while (current != null && current.next != null)
        {

            if (current.value == current.next.value)
            {
                nextNode = current.next.next;
                current.next = null;
                current.next = nextNode;
            }
            else
            {
                current = current.next;
            }
        }

        return linkedList;
    }
}

