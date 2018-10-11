using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        // This data member stores the refernece to first node in the list
        private Node head;

        // This wiil tell the numbers of nodes in a list
        private int length = 0;
        public int Length {
            get { return length; }
        }

        public void AddNodeAtFront(int data)
        {
            // Creating a new Node
            Node nodeToAdd = new Node();

            //Setting the properties of new node
            nodeToAdd.Data = data;
            nodeToAdd.nextNode = head;

            //Setting the starting point of linked list
            head = nodeToAdd;
            length++;
        }

        public void AddNodeAtLast(int data)
        {
            if (head == null)
            {
                // if current linked list is empty then this will add 
                head = new Node();

                //Setting the properties of new node
                head.Data = data;
                head.nextNode = null;
                length++;
            }
            else
            {
                // To find the last node in list
                Node lastNodeInList = head;

                while ( lastNodeInList.nextNode != null )
                {
                    lastNodeInList = lastNodeInList.nextNode;
                }

                // Setting up the new node
                Node nodeToAdd = new Node();
                nodeToAdd.Data = data;
                nodeToAdd.nextNode = null;

                // adding the new node to list
                lastNodeInList.nextNode = nodeToAdd;

                //Increment Counter
                length++;
            }
        }

        public void AddNodeAfter(Node node, int data)
        {
            if (node != null)
            {
                Node nodeToAdd = new Node();
                nodeToAdd.Data = data;
                nodeToAdd.nextNode = node.nextNode;

                node.nextNode = nodeToAdd;

                length++;
            }
            // else throw some error
        }
    }
}
