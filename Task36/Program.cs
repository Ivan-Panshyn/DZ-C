// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19;
// [-4, -6, 89, 6] -> 0;

Console.Write("Введите одномерный массив: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[number];

void masive(int number)
{
  for (int i = 0; i < number; i++)
  {
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i] + " ");
  }

}

int kolichestvo(int[] randomArray)
{
  int sum = 0;
  int i = 0;
  while (i < randomArray.Length)
  {
    sum = sum + randomArray[i];
    i = i + 2;
  }
  return sum;
}

masive(number);
Console.Write($"Cумма элементов, стоящих на нечётных позициях: { kolichestvo(randomArray)}");