namespace p05._01.MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Mergesort<T> where T : IComparable
    {
        private static T[] helperArr;

        public static void Sort(T[] arr)
        {
            helperArr = new T[arr.Length];

            Sort(arr, 0, arr.Length - 1);
        }

        private static void Merge(T[] arr, int lo, int mid, int hi)
        {
            if (IsLess(arr[mid], arr[mid + 1]))
            {
                return;
            }

            for (int index = lo; index < hi + 1; index++)
            {
                helperArr[index] = arr[index];
            }

            int i = lo;
            int j = mid + 1;

            for (int k = 0; k <= hi; k++)
            {
                if (i > mid)
                {
                    arr[k] = helperArr[j++];
                }
                else if (j > hi)
                {
                    arr[k] = helperArr[i++];
                }
                else if (IsLess(arr[i], helperArr[j]))
                {
                    arr[k] = helperArr[i++];
                }
                else
                {
                    arr[k] = helperArr[j++];
                }
            }
        }

        private static bool IsLess(T firstElement, T secondElement)
        {
            bool isLess = firstElement.GetHashCode() > secondElement.GetHashCode();

            return isLess;
        }

        private static void Sort(T[] arr, int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }


            //Sort(arr, lo, mid);
            //Sort(arr, mid + 1, hi);
            //Merge(arr, lo, mid, hi);
        }
    }
}
