using System;

namespace LeetCodeAlgoritmos
{
    public class HIndexCitations
    {
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);

            int n = citations.Length;

            if (n == 0)
                return 0;

            if (citations[0] >= n)
                return n;
                
            int hIndex = 0;
            int low = 0;
            int mid;
            int high = n - 1;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (citations[mid] >= n - mid)
                {
                    hIndex = n - mid;
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }
            return hIndex;
        }
    }
}
