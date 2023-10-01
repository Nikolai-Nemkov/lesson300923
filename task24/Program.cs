// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача №24");

// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел 
// от 1 до А. 
// 7 -> 28 
// 4 -> 10 
// 8 -> 36

int SumNumbers(int num)  // SumNumbers - название метода int num - число
{
    int sum = 0;    //  int sum - начальная накопительная переменная
    for (int i = 1; i <= num ; i++)  // по условию (от 1 до А) значит i = 1, а счетчик 
                                    // должен дойти до num, поэтому i <= num/
    {
        sum += i;  // sum = sum + 1  сумма + значение счетчика

    }
    return sum;  //   - возврат результата
}
Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");


