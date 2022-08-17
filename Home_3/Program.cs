// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array = new int[8];
int length = Array.Length;
Console.Write("[");

// void NewArray(int[] Array)
// {
// for(int i=0; i<length; i++)
// {
//     Array[i] = new Random().Next(1,100);
//     Console.Write($" {Array[i]},");
// }
// Console.Write(" ]");
// }

// NewArray(Array);


// 2 Вариант (без запатой после последней цифры) вместо 9-19 строчек

int i = 0;
while(i<length-1)
{
    Array[i] = new Random().Next(1,100);
    Console.Write($" {Array[i]},");
    i++;
}

Console.Write($" {Array[length-1]} ]");