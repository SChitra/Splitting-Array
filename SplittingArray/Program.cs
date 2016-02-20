using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplittingArray
{
    /***Given an array of numbers, split the array into two where one array contains the sum of n-1 numbers and 
    the other array with all the n-1 elements. ***/

    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 1, 5 };
            //int[] arr = { 5, 1, 9 };
            //int[] arr = { -5, 1, 4, 6, 5, 1 };
            int[] arr = { 7, 5, 12 };
            int length = arr.Length;
            if(SplitArray(arr,length)== -1)
                Console.WriteLine("Cannot be split as the sum does not have a matching number");
            else
                Console.WriteLine("The sum of the number {0}",SplitArray(arr,length));

        }

        public static int SplitArray(int[] arr, int length)
        {
            int sum = 0;
            //Calculate the sum of the array
            for(int i=0; i<= length-1; i++)
            {
                sum = sum + arr[i];
            }
            //if sum of array is even, calculate sum/2 and find the sum of the array after splitting
            if ((sum % 2) == 0)
                return sum / 2;
            else
                return -1;
        }
    }
}
