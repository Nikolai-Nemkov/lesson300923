// See https://aka.ms/new-console-template for more information
Console.WriteLine("Задача № 30");


// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] RandomArray (int min, int max, int Length)
{
    int[] arr = new int [Length];
    for (int i = 0; i < Length; i++)
    {
        arr[i] = new Random().Next(min, max +1);
    }
    return arr;
}

void Printarray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] array = RandomArray(0, 1, 8);

Printarray(array);


 
 