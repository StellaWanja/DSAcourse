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
                for (int i = position - 1; i < size; i++)
                {
                    arrayNum[i] = arrayNum[i + 1];
                }
                for (int m = 0; m < size; m++)
                {
                    Console.WriteLine(arrayNum[m]);
                }
            }
        }
        //pointer holds address, not value

        //2D ARRAYS/matrix
        //eg [2,1,3
        //    4,5,6
        //    7,8,9]
        public static void TwoDimensionalArrayTraverse()
        {
            int[,] array = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };//two-dimensional array of four rows and two columns
            //[1,2   //array[0,0], array[0,1]
            //3,4   // array[1,0], array[1,1]
            //5,6    //array[2,0], array[2,1]
            //7,8]   //array[3,0], array[3,1]
            //traverse row first
            for (int i = 0; i < array.GetLength(0); i++)
            {
                //then traverse column
                for(int j=0; j< array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }
        //Implementation of 2D array uses:
        // 1. Row major
        // 2. Column major
        //eg [1,2,3
        //    4,5,6]
        //In Row major method, data is stored as
        // [1,2,3][4,5,6] - 2 rows
        //In Column major method, data is stored as
        // [1,4][2,5][3,6] - 3 columns
    }
}
