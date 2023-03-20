// Напишите программу, 
// 1. которая принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Ввелите натуральное число: ");
int number =  Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"В числе {number} -> {sumNumber} сумм цифр");

int SumNumber(int num)
{
  int sum = 0;
  while (num > 0) 
  {
    sum += num % 10;
    num = num / 10;
  }
  return sum;
}