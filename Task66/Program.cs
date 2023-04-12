// 1. Задайте значения M и N. 
// 2. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// 3. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
  int sumNumber = SumNumber(numberM, numberN);
  Console.WriteLine(sumNumber);
}
else if (numberM < numberN)
{
  int sumNumber = SumNumber(numberN, numberM);
  Console.WriteLine(sumNumber);
}
else Console.WriteLine("Введены одинаковые значение М и N");


int SumNumber(int num1, int num2)
{
  if (num1 < num2) return 0;
  else return num1 + SumNumber(num1 - 1, num2);
}