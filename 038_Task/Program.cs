/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
Диапазон [-10, 10]. Обратите внимание на вещественных чисел
Для примера возьмём диапазон побольше. [3 7 22 2 78] -> 76
*/

// Решение

int Parameters (string message)             // метод задания параметров массива
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return (result);
}

double [] FillPrintArray (int size)         // метод заполнения и вывода на экран массива
{
    double [] array = new double [size];
    Console.WriteLine("Получен массив:");
    for (int i = 0; i < size; i++)
    {
        array [i] = Math.Round(new Random().Next(-100, 101)*0.1, 1);
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
    return (array);
}

double DiffMaxMinElements (double [] array) // метод поиска разности между макс. и мин. элементами массива
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    diff = max - min;
    return diff;
}

int size = Parameters("Введите количество элементов массива: ");
double [] array = FillPrintArray(size);
Console.WriteLine($"Разность между максимальным и минимальным элементами массива равна {DiffMaxMinElements(array)}"); 