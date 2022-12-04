// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// По условиям задачи, число может быть не целочисленным и отрицательным
// Вариант решения через перевод числа в стороку/символ и обратно


Console.Clear();

double NumberEntry(string str)                                             // Метод для ввода числа
{
    Console.Write(str);

    double number = Convert.ToDouble(Console.ReadLine());

     return number;
}

void Sum(double number)                                                     // Метод сложения цифр в числе
{
    string str = Convert.ToString(number);

    int sum = 0;

    int length = str.Length;                                                // Определение кол-ва символов в числе
    
    for (int i = 0; i < length; i++)                                         // Цикл сложения цифр
    {
        if (str[i] == ',' || str[i] == '-')                                  // Проверка на запятую и отрицательность
        {
        }
        else
        {
            sum = sum + (int)Char.GetNumericValue(str[i]);                    // Сложение
        }
    }

    Console.Write($"Сумма цифр в числе {number} равна {sum}");                // Вывод результата в консоль
}

double number = NumberEntry("Введите чило (десятичный разделитель через зяпятую): ");    // Ввод числа

Sum(number);                                                                  // Отправляем число в метод сложения цифр  