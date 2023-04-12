// 1. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int functionAccermana = FunctionAccermana(numberM, numberN);
Console.WriteLine(functionAccermana);

int FunctionAccermana(int number1, int number2)
{
    if(number1 == 0) return number2 + 1;
    else
    {
        if((number1 != 0) && (number2 == 0)) return FunctionAccermana(number1 - 1, 1);
        else return FunctionAccermana(number1 - 1, FunctionAccermana(number1, number2 - 1));
    }
}

