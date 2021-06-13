using System;

namespace LeetCodeAlgoritmos
{
    public class SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            int numeroUnico = 0;
            Array.Sort(nums);

            if (nums.Length == 1)
                return nums[0];

            if (nums[1] != nums[0])
                return nums[0];

            if (nums[nums.Length - 1] != nums[nums.Length - 2])
                return nums[nums.Length - 1];


            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    i += 2;
                }
                else
                {
                    numeroUnico = nums[i - 1];
                    return numeroUnico;
                }
            }
            return numeroUnico;
        }
    }
}
