/* Задача 3: Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int[,] RandomArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void SumOfArray(int[,] array)
{
    double sum = 0;
    int j = 0;

    for (int i = 0; j < array.GetLength(1); i++)
    {
        sum += array[i, j];
        if (i + 1 == array.GetLength(0))
        {
            sum = sum / array.GetLength(0);
            System.Console.Write("Сумма: {0:F1} \t", sum);
            j++;
            i = -1;
            sum = 0;
        }
    }
}


int[,] array = RandomArray(3, 4, -10, 10);
PrintArray(array);
SumOfArray(array);