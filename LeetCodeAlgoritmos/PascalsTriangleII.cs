using System.Collections.Generic;

namespace LeetCodeAlgoritmos
{
    public class PascalsTriangleII
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
            {
                return new List<int>() { 1 };
            }
            else if (rowIndex == 1)
            {
                return new List<int>() { 1, 1 };
            }

            return getRow(new List<int>() { 1, 1 }, 2, rowIndex);
        }

        List<int> getRow(List<int> linhaSuperior, int linhaAtual, int rowIndex)
        {

            List<int> row = new List<int>();
            row.Add(1);

            for (int i = 1; i < linhaAtual; i++)
            {
                row.Add(linhaSuperior[i - 1] + linhaSuperior[i]);
            }

            row.Add(1);

            if (linhaAtual == rowIndex)
            {
                return row;
            }
            else
            {
                return getRow(row, linhaAtual + 1, rowIndex);
            }
        }
    }
}
