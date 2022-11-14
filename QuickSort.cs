using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    //Also called partition exchange sort
    class QuickSort
    {
        //in quick sort, choose a pivot element (can be start, end, middle or random position)
        //quick sort uses divide and conquer approach
        //from start point, move to the right and stop when you find an element that is greater or equal to the pivot
        //from end point, move to the left and stop when you find element less than pivot
        //pivot is at start
        //FIRST PARTITION
        //eg [52, 14, 67, 71, 42, 38, 39, 40, 96] - 52 at arr[0] is pivot
        //from start point at arr[0], stop at 67
        //from end point at arr[n-1], stop at 40
        //swap the two values to become [52, 14, 40, 71, 42, 38, 39, 67, 96]
        //start point is at arr[2], end point at arr[n-1]
        //from start point, stop at 71
        //from end point, stop at 39
        //swap - [52, 14, 40, 39, 42, 38, 71, 67, 96]
        //once start and end point cross, swap end point with pivot
        //[38, 14, 40, 39, 42, 52, 71, 67, 96]
        //SECOND PARTITION
        //The left subarray is [38, 14, 40, 39, 42] and the right subarray is [71, 67, 96]
        //in right subarray, 71 is pivot, swap with 67 [67,71,96]
        //in left subarry, 38 is pivot, swap with 14 [14, 38, 40, 39, 42]
        //THIRD PARTITION
        //in left subarray of [40,39,42], 40 is pivot, swap with 39
        public static void QuickSortMethod(int[] arr, int leftIndex, int rightIndex)
        {
            if(leftIndex < rightIndex)
            {
                int loc = PartitionMethod(arr, leftIndex, rightIndex);
                QuickSortMethod(arr, leftIndex, loc - 1);
                QuickSortMethod(arr, loc + 1, rightIndex);
            }
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static int PartitionMethod(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = arr[leftIndex];
            int start = leftIndex;
            int end = rightIndex;

            while (start < end)
            {
                while(arr[start] < pivot)
                {
                    start++;
                }
                while(arr[end] > pivot)
                {
                    end--;
                }
                if(start <= end)
                {
                    Swap(arr, arr[start], arr[end]);
                    start++;
                    end--;
                }
            }

            Swap(arr, arr[leftIndex], arr[end]);
            return end;
        }
    }
}
