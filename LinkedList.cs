using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    //LinkedList types:
    //1. Singly
    //2. Doubly
    //3. Circular
    //4. Doubly circular
    //
    //1.Singly Linked List
    // eg 3|200(Address is 100) -> 4|300(Address is 200) -> 5|null(Address is 300)
    //can only traverse forward

    //representation of a node in Singly Linked List
    public class SinglyNode
    {
        public int data;
        public SinglyNode next;
    }
    //2. Doubly Linked List
    // has 2 pointers, for previous and next
    //eg null|100(address is 100) <--> 100|2|300(address is 200) <--> 200|3|null
    //representation of a node in Doubly Linked List
    public class DoublyNode
    {
        public int data;
        public DoublyNode next;
        public DoublyNode prev;
    }
    //3. Circular Linked List
    // eg 7|200(address is 100) -> 8|300(address is 200) -> 9|100(address is 300 and points to the first node)
    //represntation same as doubly linked list
    //
    //4. Doubly Circular Linked List
    //eg 300|1|200 -> 100|2|300 -> 200|3|100

    //ARRAY VS LINKED LIST
    //Cost of accessing an element - Array take 0(1), Linked list takes O(N)
    //Memory utilization -  array requires fixed size, linked list requires none
    //Memory requirement during insertion - array requires less than linked list
    //Insertion/deletion at end - array takes o(1), linked list takes o(N)
    //Insertion/deletion at beginning - array takes O(N), linked list takes O(1)
    //Insertion/deletion at nth position - array takes O(N), linked list takes  O(N)
    //Array can use both linary and binary search, linked list can only use linear search

    //LINKED LIST CREATION
    public class Node
    {
        public int data;
        public Node next;
       /* public Node(int x)
        {
            data = x;
            next = null;
        }*/
    }

    public class SinglyLinkedList
    {
        public Node head;
        //constructor to create an empty LinkedList
        public SinglyLinkedList()
        {
            head = null;
        }
    }
    public class LinkedList
    {
        public static void print()
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            //Add first node.
            Node first = new Node();
            first.data = 10;
            first.next = null;
            //linking with head node
            llist.head = first;

            //Add second node.
            Node second = new Node();
            second.data = 20;
            second.next = null;
            //linking with first node
            first.next = second;

            //Add third node.
            Node third = new Node();
            third.data = 30;
            third.next = null;
            //linking with second node
            second.next = third;
            Console.WriteLine(llist);

        }

    }
}
