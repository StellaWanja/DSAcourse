using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    class BinarySearch
    {
        //Binary search iterative approach
        public static int BinarySearchIterative(int[] arr, int key)
        {
            int low = 0;
            int high = arr.Length - 1;
            int mid = (low + high) / 2;

            while (low <= high)
            {
                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

        //Binary search recursive approach
        public static int BinarySearchRecursion(int[] arr, int key, int low, int high)
        {
            int mid = (low + high) / 2;

            if (low > high) return -1;
            if (key == arr[mid])
            {
                return mid;
            }
            else if (key < arr[mid])
            {
                return BinarySearchRecursion(arr, key, low, mid - 1);
            }
            else
            {
                return BinarySearchRecursion(arr, key, mid + 1, high);
            }
        }

    }
}
