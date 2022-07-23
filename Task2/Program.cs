/* Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 7 -> такого числа в массиве нет */


int[,] RandomArray(int rows, int columns)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(-100, 100 + 1);
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


void FindElement(int[,] array, int row, int column)
{
    row = row - 1;
    column = column - 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row && j == column)
            {
               
                System.Console.WriteLine($"Число: {array[i, j]}");
                return;
            }
        }

    }
    System.Console.WriteLine("Такой строки и столбца нет");
}

int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}



int rows = Prompt ("Введите количество строк: ");
int columns = Prompt ("Введите количество столбцов: ");


int[,] array = RandomArray(rows, columns);
PrintArray(array);

int elementRows = Prompt ("Введите строку: ");
int elementColumns = Prompt ("Введите столбец: ");
FindElement(array, elementRows, elementColumns);