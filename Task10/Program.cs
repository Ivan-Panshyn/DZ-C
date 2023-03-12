//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Первый метод
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = number / 10 % 10;
Console.WriteLine($"Вторая цифра -> {secondDigit}");

// Второй метод
int delFirstLastDigit = DelFirstLastDigit(number);
Console.WriteLine($"Полученное однозначное число -> {delFirstLastDigit}");

int DelFirstLastDigit(int num) 
{
  int result = number / 10 % 10;
  return result;
}