using System.Collections.Generic;

namespace Grokking
{
    public static partial class Algos
    {
        public static int? BinarySearch(int[] list, int item)
        {
            int low = 0; 
            int high = list.Length;
            int mid, guess;

            while(low <= high) {
                mid = (low + high)/2;
                guess = list[mid];

                if (guess == item) return mid;
                if (guess > item) high = mid--;
                else low = mid + 1;
            }

            return 0;
        }
    }
}