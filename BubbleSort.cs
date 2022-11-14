using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgos
{
    class BubbleSort
    {
        //Bubble Sort
        //eg [8,3,1,7,0]
        //pass 1 -> [3,1,7,0,8]
        //pass 2 -> [1,3,0,7,8]
        //pass 3 -> [1,0,3,7,8]
        //pass 4 -> [0,1,3,7,8]
        public static void BubbleSortMethod(int[] arr)
        {
            //first loop is for passes, which by default takes n-1 to sort
            //eg if n=5, the number of times to loop (passes) will be 4
            // second loop is for comparisons inside the pass
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            //This can also be represented by changing the comparisons loop to remove unecessary comparisons
            //eg in 1st pass - takes 4 comparisons, in 3rd pass, takes 2 comparisons rather than the 4 
            //eg to sort [5,1,4,2,8]
            //pass 1 -> [1,4,2,5,8]
            //pass 2 -> [1,2,4,5,8]
            //pass 3 -> the array is already sorted, but our algorithm does not know if it is completed.
            //       -> will need another loop without swap to know that it is sorted
            for (int i = 0; i < arr.Length - 1; i++)
            {
                //the inclusion of the flag is to prevent using another pass when array has already been sorted
                // eg array sorted using 3 passes, but because n-1=4, requires uneccessary 4th pass
                var flag = 0;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[i] < arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flag = 1;
                    }
                }
                if(flag == 0)
                {
                    break;
                }
            }
        }
    }
}
