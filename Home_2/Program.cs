// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) number = number * -1;

int sum = 0;
int i = 0;

while(number > 0)
{
    int NewNumber = number % 10;
    i = NewNumber;
    number = number / 10;
    sum = sum + i;
}

Console.WriteLine(sum);