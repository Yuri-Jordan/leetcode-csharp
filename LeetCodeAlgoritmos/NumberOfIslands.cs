namespace LeetCodeAlgoritmos
{
    public class NumberofIslands
    {
        private int DFS(char[][] grid, int linha, int coluna)
        {
            char colunaVista = '0';

            if (linha < 0 || linha >= grid.Length ||
                coluna < 0 || coluna >= grid[linha].Length ||
                grid[linha][coluna] == colunaVista)
            {
                return 0;
            }

            grid[linha][coluna] = colunaVista;

            DFS(grid, linha - 1, coluna);
            DFS(grid, linha + 1, coluna);
            DFS(grid, linha, coluna - 1);
            DFS(grid, linha, coluna + 1);
            DFS(grid, linha, coluna);
            return 1;
        }

        public int NumberOfIslands(char[][] grid)
        {
            int quatidadeDeIlhas = 0;

            for (int linha = 0; linha < grid.Length; linha++)
            {
                for (int coluna = 0; coluna < grid[linha].Length; coluna++)
                {
                    if (grid[linha][coluna] == '1')
                    {
                        quatidadeDeIlhas += DFS(grid, linha, coluna);
                    }
                }
            }
            return quatidadeDeIlhas;
        }
    }
}
