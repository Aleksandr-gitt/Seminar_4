// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void ras4et(int number1, int number2)
{
    int result = Convert.ToInt32(Math.Pow(number1,number2));
    Console.WriteLine($"{number1}^{number2} = {result}");
}
      
     
Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень в которую необходимо возвести введенное ранее число: ");
int power = Convert.ToInt32(Console.ReadLine());

if(power >= 0) ras4et(number, power); 
else Console.WriteLine("У вас отрицательная степень числа");
    
   

    
