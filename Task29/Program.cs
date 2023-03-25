// Напишите программу, 
// 1. которая задаёт массив из 8 элементов и 
// 2. выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

FillArray(array);
Console.Write("[");
WriteArray(array);
Console.Write("]");

void FillArray(int[] arr)
{
  Random rand = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rand.Next(0, 99);
  }
}

void WriteArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1)
    {
      Console.Write($"{arr[i]}, ");
    }
    else
    {
      Console.Write($"{arr[i]}");
    }
  }
}