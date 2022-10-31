using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    public class Arrays
    {
        //1. Traversal of array
        public static void ArrayTraversalMethod()
        {
            //array - collection of items of same data type
            //declarartion of 1D array
            int[] a = new int[5]; //size of 5
            //a value takes 4 bytes
            //accessing data is 0(1) if you know the index of value (Random access)
            //drawback of array - uses fixed size

            int[] b = new int[50]; //will allocate 200 bytes
            int[] C = new int[5] { 10, 20, 30, 40, 50 }; //size of 5
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(C[i]);
            }
        }
        public static void ArrayInsertionMethod()
        {
            //2. Insertion at specific position
            //Insertion/deletion at beginning - O(n)
            //Insertion/deletion at end - O(1)
            //Insertion/deletion at nth position - O(n)
            // Shift values to right
            int[] arrayNum = new int[10];
            int size, position, num;

            Console.WriteLine("Input the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input elements in the array in ascending order:\n");
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                arrayNum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter data to insert");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position");
            position = int.Parse(Console.ReadLine());
            //start shifting from the last value of the array
            //till where position has been reached
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Position is invalid");
            }
            else
            {
                for (int i = size; i >= position; i--)
                {
                    //shift values to right eg a[5] = a[4] shift 50 from index 4 to index 5
                    // a[4] will hold the value of a[3]
                    arrayNum[i] = arrayNum[i - 1];
                }
                arrayNum[position - 1] = num;
                for (int m = 0; m <= size; m++)
                {
                    Console.WriteLine(arrayNum[m]);
                }
            }
        }

        public static void ArrayDeletionMethod()
        {
            //in deletion, shift items to left
            int[] arrayNum = new int[10];
            int size, position, num;

            Console.WriteLine("Input the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input elements in the array in ascending order:\n");
            for (int i = 0; i < size; i++)
            {
                Console.Write("element - {0} : ", i);
                arrayNum[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter position to delete");
            position = int.Parse(Console.ReadLine());

            if (position <= 0 || position > size)
            {
                Console.WriteLine("Position is invalid");
            }
            else
            {
                for(int i=position-1; i<size; i++)
                {
                    arrayNum[i] = arrayNum[i+1];
                }
                for (int m = 0; m < size; m++)
                {
                    Console.WriteLine(arrayNum[m]);
                }
            }
        }
    }
}
