using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// UC1 - Inserting the node at last and displaying the linked list
    /// UC2 - Inserting the node at front
    /// UC3 - Appending 
    /// UC4 - Insert at middle
    /// UC5 - Deleting the node at first
    /// UC6 - Deleting the node at last
    /// UC7 - Search
    /// </summary>
    public class LinkedListOperations
    {
        //Creating a head node to point the first element
        public NodeFields head;
        //Creating a method to insert last 
        public void InsertLast(int new_data)
        {
            NodeFields newnode = new NodeFields(new_data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                NodeFields lastNode = GetLastNode();
                lastNode.next = newnode;
            }
            Console.WriteLine("Inserted last into list " + newnode.data);
        }

        //Insering at last
        public void InsertFront(int new_data)
        {
            NodeFields newnode = new NodeFields(new_data);
            newnode.next = this.head;
            this.head = newnode;
            Console.WriteLine("Inserted front into list " + newnode.data);
        }

        //Inserting the node at middle
        public void InsertBetween(int pos, int new_data)
        {
            NodeFields newnode = new NodeFields(new_data);
            if (pos == 1)
            {
                newnode.next = this.head;
                head = newnode;
            }
            else if (pos <= 0)
            {
                Console.WriteLine("Invalid Position!!!");
            }
            else if (pos > 0)
            {
                NodeFields temp = head;
                while (pos != 0)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine("After insertion performed between tow nodes");
                        newnode.next = temp.next;
                        temp.next = newnode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                    pos--;
                }
            }
        }

        //Deleting the node at first

        public NodeFields DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }

        //Deleting the last node

        public NodeFields DeleteLast()
        {
            NodeFields newnode = this.head;
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return null;
            }
            while (newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return newnode;

        }

        //For Searching
        public int Search(int value)
        {
            NodeFields temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Element found.. " + value);
                    return value;
                }
                temp = temp.next;

            }
            Console.WriteLine("Element not found!!!!!!!!");
            return value;
        }

        public NodeFields GetLastNode()
        {
            NodeFields temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        //Display the nodes
        public void Display()
        {

            NodeFields temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
