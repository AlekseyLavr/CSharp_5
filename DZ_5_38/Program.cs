﻿// See https://aka.ms/new-console-template for more information
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 100);
}
int ReleaseArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
            sum += array[i];
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] ");
ReleaseArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетной позиции = {ReleaseArray(array)}");
