/* Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5  7    -2   -0,2
1   -3,3   8   -9,9
8    7,8  -7,1  9 */

double[,] RandomArray(int rows, int columns, int min, int max){
    double[,] answer = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        { 
            answer[i, j] = rnd.Next(min, max +1) + rnd.NextDouble();
        }
    }
    return answer;
}

void PrintArray(double[,] array) {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write("{0:F1} \t", array[i, j]);
        }
    }
    System.Console.WriteLine();
}

double [,] array = RandomArray (4, 5, -10, 10);
PrintArray(array);

