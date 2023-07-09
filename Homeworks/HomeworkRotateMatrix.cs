using System;

public class HomeworkRotateMatrix {
    
	public static void Main() {
        RotateMatrix();
    }

	public static void RotateMatrix(){
		
		int[,] matrix = new int[,]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };
        printMatrix(matrix);

        rotate90(ref matrix);
        rotate90(ref matrix);
        rotate180(ref matrix);
        rotate270(ref matrix);
        rotate360(ref matrix);
        
        void printMatrix(int[,] matrix)
        {
            Console.WriteLine("Ваша матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine("");
            }
        }

        void rotate90m(ref int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, rows - i - 1] = mat[i, j];
                }
            }
            mat = result;
        }

        void rotate90(ref int[,] mat)
        {
            Console.WriteLine("Поворачиваем на 90 градусов");
            rotate90m(ref mat);
            printMatrix(matrix);
        }

        void rotate180(ref int[,] mat)
        {
            Console.WriteLine("Поворачиваем на 180 градусов");
            rotate90m(ref mat);
            rotate90m(ref mat);
            printMatrix(matrix);
        }
        void rotate270(ref int[,] mat)
        {
            Console.WriteLine("Поворачиваем на 270 градусов");
            rotate90m(ref mat);
            rotate90m(ref mat);
            rotate90m(ref mat);
            printMatrix(matrix);
        }
        void rotate360(ref int[,] mat)
        {
            Console.WriteLine("Поворачиваем на 360 градусов");
            rotate90m(ref mat);
            rotate90m(ref mat);
            rotate90m(ref mat);
            rotate90m(ref mat);
            printMatrix(matrix);
        }
	}

}

