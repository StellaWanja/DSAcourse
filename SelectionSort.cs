using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    //in selection sort, we have sorted and unsorted array
    //loop through and find minimum value from unsorted array, and swap with value at start index of unsorted array
    //eg [7,4,10,8,3,1]
    // pass 1 -> [1,4,10,8,3,7] // so 1 is in sorted array
    // pass 2 -> [1,3,10,8,4,7]
    // pass 3 -> [1,3,4,8,10,7]
    // pass 4 -> [1,3,4,7,10,8]
    // pass 5 -> [1,3,4,7,8,10]
    //pass = n - 1
    class SelectionSort
    {
        public static void SelectionSortMethod(int[] arr)
        {
            //loop through pass
            for(int i=0; i < arr.Length - 1; i++)
            {
                int min = i;
                //loop through to find the minimum value
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                //swap numbers at this point
                if(min != i)
                {
                    var temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;

                }
            }
        }
    }
}
