// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача № 26");

// 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountOfNamber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num/=10;
        count++;
    }
    return count;
}


Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int countOfNamber = CountOfNamber(number);
Console.WriteLine($"Количество цифр в числе -> {countOfNamber}");