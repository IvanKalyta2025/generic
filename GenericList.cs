using System;

namespace generic
{
    // I declare a generic list class that can hold values of any type T.
    public class GenericList<T> : IGrensesnitt<T>
    {
        //from https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
        // I create an inner node class to store each value and a pointer to the next node.
        private sealed class Node
        {
            // I capture the value inside the constructor as soon as the node is created.
            public Node(T value)
            {
                // I remember the actual data that was passed in.
                Data = value;
            }

            // I keep the value stored in this node.
            public T Data { get; }
            // I keep a reference to the next node in the chain, or null if this is the end.
            public Node? Next { get; set; }
        }

        // I store the first node so iteration can always start from the head.
        private Node? head;
        // I store the last node so I can append new nodes quickly.
        private Node? tail;
        // I keep track of how many items are currently inside the list.
        private int count = 0;

        // I append a new node to the tail of my linked list.
        // I add the new value to the end of the list and adjust the pointers.
        public void Add(T item)
        {
            // I create a fresh node that contains the incoming value.
            Node node = new(item);

            // If the list was empty, the new node becomes both head and tail.
            if (head is null)
            {
                head = node;
                tail = node;
            }
            else
            {
                // If the list already has elements, I link the new node after the current tail.
                tail!.Next = node;
                // I move the tail reference so it points at the newly added node.
                tail = node;
            }

            // I increment the count so the size reported by the list stays accurate.
            count++;
        }

        // I return the value at the requested position while ensuring the index is valid.
        // I fetch an item by its index and stop callers from leaving the valid range.
        public T Get(int index)
        {
            // I guard against negative indices and anything that is beyond the last element.
            if (index < 0 || index >= count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            // I start scanning the linked list from the head node.
            Node? current = head;
            // I remember which index belongs to the node I am currently looking at.
            int currentIndex = 0;

            // I walk through the nodes until there are no more left.
            while (current is not null)
            {
                // Whenever the current index matches the target index, I return the value.
                if (currentIndex == index)
                {
                    return current.Data;
                }

                // I follow the link to the next node in the chain.
                current = current.Next;
                // I step the index forward because I moved to the next node.
                currentIndex++;
            }

            // I never expect to reach this point, yet I fail hard if the traversal breaks.
            throw new InvalidOperationException("Node traversal failed unexpectedly.");
        }

        // I report how many values I have successfully stored.
        // I expose the current size so callers know how many items the list contains.
        public int Count => count;
    }
}
