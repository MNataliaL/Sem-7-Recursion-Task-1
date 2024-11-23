//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumDigits (int num) //123, 12, 1, 0
{
    if (num == 0) return 0;  
    return num % 10 + SumDigits(num / 10); //123, 12, 1;
    // 0 => 1 % 10 = 1 => 12 % 10 = 2  => 123 % 10 => 0 + 1 + 2 + 3
}



Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigits(number));
