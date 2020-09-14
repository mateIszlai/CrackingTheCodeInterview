namespace ArraysAndStrings
{
    public class MatrixZeroer
    {
        public int[][] AddZeros(int[][] matrix)
        {
            if (matrix[0] == null)
                return matrix;

            var columsToZero = new bool[matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                var rowToZero = false;
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (columsToZero[j] || rowToZero)
                    {
                        matrix[i][j] = 0;
                        continue;
                    }
                    if(matrix[i][j] == 0)
                    {
                        rowToZero = true;
                        columsToZero[j] = true;
                        for (int k = j; k >= 0; k--)
                        {
                            matrix[i][k] = 0;
                        }
                        for (int l = i; l >= 0; l--)
                        {
                            matrix[l][j] = 0;
                        }
                    }

                }
            }
            return matrix;
        }
    }
}
