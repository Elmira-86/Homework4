//  Домашнее задание 1

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B");
// int b = Convert.ToInt32(Console.ReadLine());

// {
//     Console.WriteLine("A в степени B равно: " + Math.Pow(a, b));
// }

//  Домашнее задание 3

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] nums = new int[8];
Console.Write("[");
Random random = new Random();
for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(1, 100); 
        Console.Write(" " + nums[i] + ",");
         }
Console.Write("]");
