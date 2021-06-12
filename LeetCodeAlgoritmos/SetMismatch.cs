using System;

namespace LeetCodeAlgoritmos
{
    public class SetMismatch
    {
        public int[] FindErrorNums(int[] nums)
        {
            int[] result = new int[2];
            int NAO_VISTO = 0;
            int VALOR_REPETIDO = 0;
            int VALOR_AUSENTE = 1;

            foreach (var i in nums)
            {
                int indice = Math.Abs(i) - 1;

                if (nums[indice] < NAO_VISTO)
                {
                    result[VALOR_REPETIDO] = Math.Abs(i);
                }
                else
                {
                    nums[indice] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > NAO_VISTO)
                {
                    result[VALOR_AUSENTE] = i + 1;
                }
            }
            return result;
        }
    }
}
