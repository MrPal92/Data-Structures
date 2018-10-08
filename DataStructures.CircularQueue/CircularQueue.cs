using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.CircularQueue
{
    public class CircularQueue
    {
        int?[] queue;

        // No of elements in a queue at particular instance. 
        private int ElementCount { get; set; }

        // Size of the queue
        public int Length { get; }

        // Pointers to Front element and Rear element in queue
        private int front, rear = 0;

        // Constructor
        CircularQueue()
        {
            queue = new int?[10];
            ElementCount = 0;
        }

        // Constructor Overloading
        CircularQueue(int size)
        {
            queue = new int?[Length = size];
            ElementCount = 0;
        }


        // Method to add new elements in queue
        public void Enque(int value)
        {
            // If there is no element in a queue then it will add new element
            // and increment the Element count.
            if (ElementCount == 0)
            { 
                queue[rear] = value;
                ElementCount++;
            }
            // If queue is full then it will throw an exception
            else if (ElementCount == Length - 1)
            {
                // throw exception
            }
            else
            {
                // If Rear is pointing to the last index of the data structue
                // then it will set the rear to index 0 and add new element.
                if (rear == Length - 1)
                {
                    queue[rear = 0] = value;
                    ElementCount++;
                }
                else
                {
                    queue[++rear] = value;
                    ElementCount++;
                }
            }
        }

        // Method to fetch element from a queue
        public int Dequeue()
        {
            int temp;

            if (ElementCount == 0)
            {
                // throw exception no element
                return 0;
            }
            else if (front == Length - 1)
            {
                temp = (int)queue[front];
                queue[front] = null;
                front = 0;
                ElementCount--;
                return temp;
            }
            else
            {
                temp = (int)queue[front];
                queue[front++] = null;
                ElementCount--;
                return temp;
            }
        }
    }
}
