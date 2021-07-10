using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList program");
            int num = Convert.ToInt32(Console.ReadLine());
            //Creating object for Linked list class
            LinkedListOperations Llist = new LinkedListOperations();
            switch (num)
            {
                //Inserting node at last
                case 1:
                    Llist.InsertLast(56);
                    Llist.InsertLast(30);
                    Llist.InsertLast(70);
                    Llist.Display();
                    break;

                //Inserting node at front
                case 2:
                    Llist.InsertFront(56);
                    Llist.InsertFront(30);
                    Llist.InsertFront(70);
                    Llist.Display();
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
