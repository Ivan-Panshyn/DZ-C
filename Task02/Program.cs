// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число a: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int numberb = Convert.ToInt32(Console.ReadLine());
if(numbera > numberb)
{
  Console.WriteLine("Первое число большего второго");
}
else if (numbera < numberb)
{
  Console.WriteLine("Первое число меньше второго");
}
else
{
  Console.WriteLine("Первое и второе число одинаковы");
}
