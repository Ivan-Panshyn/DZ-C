// Напишите цикл, 
// 1. который принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int naturnNumber = NaturnNumber(numberA, numberB);
Console.WriteLine("Степень числа: " + naturnNumber);

int NaturnNumber(int numberA, int numberB)
{
  int result = 1;
  for (int i = 1; i <= numberB; i++)
  {
    result = result * numberA;
  }
  return result;
}