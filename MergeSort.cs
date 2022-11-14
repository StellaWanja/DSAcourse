using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    class MergeSort
    {
        public static int[] MergeSortMethod(int[] arr)
        {
            if (arr.Length < 2)
            {
                Console.WriteLine("Not Applicable");
            }
            int mid = arr.Length / 2;
            int[] left;
            int[] right;
            left = new int[mid];
            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (arr.Length % 2 == 0)
            {
                right = new int[mid];
            }
            //if array has an odd number of elements, the right array will have one more element than left
            else
            {
                right = new int[mid + 1];
            }
            //populate left array
            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];
            }        
            //populate right array
            int x = 0;
            for (int i = mid; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }  

            return Merge(MergeSortMethod(left), MergeSortMethod(right));
        }

        public static int[] Merge(int[] leftArr, int[] rightArr)
        {
            int resultLength = leftArr.Length + rightArr.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < leftArr.Length || indexRight < rightArr.Length)
            {
                //if both arrays have elements  
                if (indexLeft < leftArr.Length && indexRight < rightArr.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (leftArr[indexLeft] <= rightArr[indexRight])
                    {
                        result[indexResult] = leftArr[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = rightArr[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < leftArr.Length)
                {
                    result[indexResult] = leftArr[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < rightArr.Length)
                {
                    result[indexResult] = rightArr[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
