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
               
                //Inserting the node at middle
                case 3:
                    Llist.InsertLast(56);
                    Llist.InsertLast(70);
                    Llist.InsertBetween(2, 30);
                    Llist.Display();
                    break;
                
                //Deleting the node at first
                case 4:
                    Llist.InsertFront(56);
                    Llist.InsertFront(30);
                    Llist.InsertFront(70);
                    Llist.DeleteFirst();
                    Llist.Display();
                    break;

                //Deleting the last node
                case 5:
                    Llist.InsertLast(56);
                    Llist.InsertLast(30);
                    Llist.InsertLast(70);
                    Llist.DeleteLast();
                    Llist.Display();
                    break;

                //Searching
                case 6:
                    Llist.InsertLast(56);
                    Llist.InsertLast(30);
                    Llist.InsertLast(70);
                    Llist.Search(56);
                    break;

                //Search and insert the node
                case 7:
                    Llist.InsertLast(56);
                    Llist.InsertLast(30);
                    Llist.InsertLast(70);
                    Llist.InsertMiddle(30, 40);
                    Llist.Display();
                    break;


                //Search and delete the node
                case 8:
                    Llist.InsertLast(56);
                    Llist.InsertLast(30);
                    Llist.InsertLast(40);
                    Llist.InsertLast(70);
                    Llist.Display();
                    Llist.DeleteBetween(40);
                    Llist.Display();
                    break;

                //Sorting
                case 9:
                    Llist.InsertLast(56);
                    Llist.InsertLast(30);
                    Llist.InsertLast(40);
                    Llist.InsertLast(70);
                    Llist.Sort();
                    Llist.Display();
                    break;

                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
