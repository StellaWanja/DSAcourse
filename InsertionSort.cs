using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    //in insertion sort, we split array into 2: sorted and unsorted sublist
    //eg in array [5,4,10,1,6,2], 5 is sorted, rest are unsorted
    // we now compare the unsorted and insert into sorted's appropriate location by shifting sorted array to the right
    //in the sort array, for loop decrements (starts from n-1 to 0th index)
    //in unsorted array, for loop increments (starts from 0th index)
    class InsertionSort
    {
        public static void InsertionSortMethod(int[] arr)
        {
            for(int i=1; i<arr.Length; i++)
            {
                var temp = arr[i];
                var j = i - 1;
                while(j>=0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
}
