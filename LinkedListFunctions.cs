using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    //Traverse a Singly Linked List
    public class MainNode
    {
        public int data;
        public MainNode next;
        public MainNode(int x)
        {
            data = x;
            next = null;
        }
    }

    public class TraverseSinglyLinkedList
    {
        public MainNode head;
        public TraverseSinglyLinkedList()
        {
            head = null;
        }

        public void Traverse()
        {
            var temp = head;
            if(temp != null)
            {
                Console.Write("The list contains:");
                while(temp != null)
                {
                    Console.Write(temp.data);
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("list is empty");
            }
        }
    }
    public class InsertAtStartSinglyLinkedList
    {
        public MainNode head;
        public InsertAtStartSinglyLinkedList()
        {
            head = null;
        }
        public void InsertAtStart(int data)
        {
            //eg we pass in 10 first when head is null
            //so node holds the value 10
            //next we pass in 20 which is stored in node
            MainNode newHead = new MainNode(data);
            //is head null, yes at 10
            //is head null, no since 10 is head
            if (head == null)
            {
                //therefore head equals 10
                head = newHead;
            }
            //therefore
            //temp becomes head which is 10
            var temp = head;
            //head then becomes 20 since node holds the value 20  
            head = newHead;
            //we change the reference of next node from head to temp, which is value 10
            // so it becomes 20 -> 10
            head.next = temp;
        }
    }

    public class InsertAtEndOfSinglyLinkedList
    {
        public MainNode head;
        public InsertAtEndOfSinglyLinkedList()
        {
            head = null;
        }
        public void InsertAtEnd(int data)
        {
            //eg we pass in 10 first when head is null
            //so node holds the value 10
            //next we pass in 20 which is stored in node
            MainNode newNode = new MainNode(data);
            //is head null, yes at 10
            //is head null, no since 10 is head
            if (head == null)
            {
                //therefore head equals 10
                head = newNode;
            }
            //eg holds 10
            var temp = head;
            //temp.next = 20
            while(temp.next != null)
            {
                //therefore, temp = 20...
                temp = temp.next;
            }
            temp.next = newNode;
        }
    }
    public class InsertAtNthPositionOfSinglyLinkedList
    {
        public MainNode head;
        public InsertAtNthPositionOfSinglyLinkedList()
        {
            head = null;
        }
        public void InsertAtNthPosition(int data, int position)
        {
            MainNode newNode = new MainNode(data);
            if(position < 1)
            {
                Console.WriteLine("not valid position");
            }
            else if(position == 1)
            {
                head = newNode;
            }
            else
            {
                if(head == null)
                {
                    head = newNode;
                }
                var temp = head;
                int i = 1;
                //position is 3
                //10 -> 20 -> 30 -> 40 -> 50
                while(i < position)
                {
                    temp = temp.next;
                    i++;
                }
                //add address/link of the new node first
                newNode.next = temp.next;
                temp.next = newNode;

            }
        }
    }

    public class RemoveAtStartOfSinglyLinkedList
    {
        public MainNode head;
        public RemoveAtStartOfSinglyLinkedList()
        {
            head = null;
        }
        public void RemoveAtStart()
        {
            //create a temp variable that holds Head eg Head = 10, so temp = 10
            var temp = head;
            //set the head to the next node eg 20
            head = temp.next;
            //unlink the first node 10 by removing its pointer to 20
            //so the link of temp to 20 = null
            temp.next = null;
        }
    }

    public class RemoveAtEndOfSinglyLinkedList
    {
        public MainNode head;
        public RemoveAtEndOfSinglyLinkedList()
        {
            head = null;
        }
        public void RemoveAtEnd()
        {
           //loop through till second last item points to a null address
           //eg 40 points to 50 which has no pointer
           // eg 10 -> 20 -> 30 -> 40 -> 50
            if(head == null || head.next == null)
            {
                Console.WriteLine("null"); 
            }
            else
            {
                var temp = head;
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }

        }
    }

    public class RemoveAtPositionOfSinglyLinkedList
    {
        public MainNode head;
        public RemoveAtPositionOfSinglyLinkedList()
        {
            head = null;
        }
        public void RemoveAtPosition(int position)
        {
            if(position < 1)
            {
                Console.WriteLine("invalid");
            }
            else if(position == 1 && head != null)
            {
                var delNode = head;
                head = delNode.next;
                delNode = null;
            }
            else
            {
                var temp = head;
                for(int i = 1; i < position - 1; i++)
                {
                    if(temp != null)
                    {
                        temp = temp.next;
                    }
                }
                // If the previous node and next of the previous  
                //   is not null, adjust links 
                if (temp != null && temp.next != null)
                {
                    temp.next = temp.next.next;
                }
                else
                {

                    //5. Else the given node will be empty.
                    Console.Write("\nThe node is already null.");
                }
            }
        }
    }


    //test the code
    class LinkedListFunctions
    {

    }
}
