// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число a: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число b: ");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число c: ");
int numberc = Convert.ToInt32(Console.ReadLine());
if (numbera > numberb)
{
  Console.WriteLine("Число a максимальное");
}
else if (numberb > numberc)
{
  Console.WriteLine("Число b максимальное");
}
else if (numberc > numbera)
{
  Console.WriteLine("Число c максимальное");
}
