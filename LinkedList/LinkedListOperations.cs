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
    /// </summary>
    class LinkedListOperations
    {
        //Creating a head node to point the first element
        public NodeFields head;
        //Creating a method to insert last 
        public void InsertLast(int new_data)
        {
            NodeFields new_node = new NodeFields(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                NodeFields lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("Inserted last into list " + new_node.data);
        }

        public void InsertFront(int new_data)
        {
            NodeFields new_node = new NodeFields(new_data);
            new_node.next = this.head;
            this.head = new_node;
            Console.WriteLine("Inserted front into list " + new_node.data);
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
