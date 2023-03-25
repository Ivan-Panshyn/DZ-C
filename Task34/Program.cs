// Задайте массив заполненный случайными положительными трёхзначными числами. 
// 1. Напишите программу, которая 
// 2.покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[number];

void massive(int number)
{
  for (int i = 0; i < number; i++)
  {
    randomArray[i] = new Random().Next(99, 999);
    Console.Write(randomArray[i] + " ");
  }
}

int kolichestvo(int[] randomArray)
{
  int kolichestvo = 0;
  for (int i = 0; i < randomArray.Length; i++)
  {
    if (randomArray[i] % 2 == 0)
      kolichestvo = kolichestvo + 1;
  }
  return kolichestvo;
}
massive(number);
Console.Write($"Количество чётных чисел в массиве: {kolichestvo(randomArray)}");