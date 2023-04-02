// 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// 2. и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента по строке: ");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента по столбцу: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());


int[,] array2d = CreateMatrixRndInt(3, 4, 5, 100);
if (numberRows >= 0 && numberColumns >= 0)
{
  PrintMatrix(array2d);
  SearchElementMatrix(array2d, numberRows, numberColumns);
}
else Console.WriteLine("Надо ввести целые положительные числа");

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


void SearchElementMatrix(int[,] matrix, int numRows, int numColumns)
{
  if (numRows < matrix.GetLength(0) && numColumns < matrix.GetLength(1))
  {
    Console.WriteLine($"Значение элемента в массиве - {matrix[numRows, numColumns]}");
  }
  else
  {
    Console.WriteLine($"  Значение позиции ({numRows}, {numColumns}) массива -> такого элемента в массиве нет.");
  }
  Console.WriteLine();
}
