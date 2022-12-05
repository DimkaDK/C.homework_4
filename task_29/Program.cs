//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
//В условии идет массив из 8 элементов, а в примерах из различного кол-ва элементов. Делаем массив из случайного кол-ва элементов (1-100) со случайными значениями (1-100)

Console.Clear();

int[] RandomArray()
{
    int randomNumber = new Random().Next(1, 100);

    int[] array = new int[randomNumber];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i < array.Length - 1) Console.Write(", ");
    } 
}

int[] result = RandomArray();

PrintArray(result);