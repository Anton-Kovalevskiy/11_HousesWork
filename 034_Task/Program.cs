/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// Решение

int Parameters (string message)         // метод задания параметров массива
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return (result);
}

int [] FillPrintArray (int size)        // метод заполнения и вывода на экран массива
{
    int [] array = new int [size];
    Console.WriteLine("Получен массив:");
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(100,1000);
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
    return (array);
}

int CountEvenNumber (int [] array)      // метод поиска количества чётных элементов массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    } 
    return (count);
}

int size = Parameters("Введите количество элементов массива: ");
int [] array = FillPrintArray(size);
Console.WriteLine($"Количество чётных элементов массива равно {CountEvenNumber(array)}"); 