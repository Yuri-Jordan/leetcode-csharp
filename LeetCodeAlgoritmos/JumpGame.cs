using System;

namespace LeetCodeAlgoritmos
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int indexAlcancavel = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (indexAlcancavel < i)
                {
                    return false;
                }
                indexAlcancavel = Math.Max(indexAlcancavel, i + nums[i]);
            }
            return true;
        }
    }
}
