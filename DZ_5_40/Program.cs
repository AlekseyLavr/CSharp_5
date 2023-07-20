// See https://aka.ms/new-console-template for more information
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void InputArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 100);
}
int ReleaseArray(int[] array)
{
    int dif = 0;
    for (int i = 0; i < array.Length; i++)
        dif = array.Max() - array.Min();
    return dif;    
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}] ");
ReleaseArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {ReleaseArray(array)}");
