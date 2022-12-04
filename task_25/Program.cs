// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

double NumberEntry(string str)                                                              // Метод для ввода числа
{
    Console.Write(str);

    double number = double.Parse(Console.ReadLine());

    return number;
}

void Exponentiation(double a, double b)                                                    // Метод возведения в степень, с последующим выводом результата в консоль
{
    double exp = 1;

    for (int i = 1; i <= b; i++)                                                            // Цикл возведения в степень
    {
        exp = exp * a;
    }

    exp = Math.Round(exp, 2);                                                               // Округление результата до двух знаков после запятой

    Console.Write($"Число {a} возведенное в степень {b} равно {exp} (результат округлен до двух знаков после запятой)");
}

double a = NumberEntry("Введите чило А: ");                                                 // Ввод чила А

double b = NumberEntry("Введите чило В (число В должно быть натуральным): ");               // Ввод чила В

if (Convert.ToInt32(b) == Convert.ToDouble(b))                                              // Проверка числа В на "натуральность"
{
    Exponentiation(a, b);                                                                   // Ввод чисел в метод возведения в степень
}
else Console.WriteLine($"Число {b} не является натуральным");                               // Вывод сообщения о некорректности введенных данных                                                                     