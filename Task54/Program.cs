// 1. Задайте двумерный массив. 
// 2. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int numberB = Convert.ToInt32(Console.ReadLine());


int[,] array2d = CreateMatrixRndInt(numberA, numberB, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
SortArray2d(array2d);
PrintMatrix(array2d);


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rand = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rand.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine("]");
  }
}

void SortArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    for (int j = 0; j < arr.Length - 1; j++)
    {
      if (arr[j] > arr[j + 1])
      {
        int temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
  }
}

void SortArray2d(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int[] array = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      array[j] = matrix[i, j];
    }
    SortArray(array);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = array[j];
    }
  }
}