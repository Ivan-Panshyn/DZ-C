// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("Введите массив вещественных чисел: ");
int number = Convert.ToInt32(Console.ReadLine());
decimal[] randomArray = new decimal[number];

void massive(int number)
{
  Random rnd = new Random();
  for (int i = 0; i < number; i++)
  {
    randomArray[i] = new Random().Next(1, 100);;
    Console.Write($"{randomArray[i]:F1} ");
  }
}

decimal difference(decimal[] randomArray)
{
  decimal min = randomArray[0];
  decimal max = randomArray[0];
  int i = 1;
  while (i < randomArray.Length)
  {
    if (max < randomArray[i])
      max = randomArray[i];
    if (min > randomArray[i])
      min = randomArray[i];
    i = i + 1;
  }
  return max - min;
}

massive(number);
Console.Write($"Разница между максимальным и минимальным элементов массива: {difference(randomArray):F1}");