// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача № 27");
Console.WriteLine();

// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
  { 
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;                      // advance - продвигать
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

Console.WriteLine();