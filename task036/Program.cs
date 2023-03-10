// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример: [3, 7, 23, 12] -> 19
//         [-4, -6, 89, 6] -> 0

//Вариант 1:
// void FillArray(int[] coll)                                                  // создаем метод FillArray для создания и печати массива
// {
//     for (int i = 0; i < coll.Length; i++)                                   // пока index меньше чем length будем делать ->
//     {
//         Console.Write($"{coll[i] = new Random().Next(1, 10)}, ");           // выводим на печать собранный массив из цифр от 1 до 10 (можно варьировать)
//     }
//     Console.Write("\b\b");                                                  // убираем запятушку
// }

// int NotEvenI(int[] arr)                        // создаем метод для проверки не четности индекса массива
// {
//     int sum = 0;                               // создаем переменную sum со стартовым значением 0
//     for (int i = 0; i < arr.Length; i++)       // пока i меньше длинны полученного массива, то делаем ->
//     {
//         if (i % 2 != 0) sum = sum + arr[i];    // если выбранный индекс делится на 2 с остатком, то прибавляем к сумме символ под данным индексом
//     }
//     return sum;                                // выводим sum
// }

// int[] array = new int[new Random().Next(3, 10)];   // задаем массив с рандомным количеством цифр внутри 
// Console.Write("[");                                // начало печати результата
// FillArray(array);                                  // запускаем метод заполнения массива
// Console.Write($"] -> {NotEvenI(array)}");          // выводим на печать результат



// Вариант 2(компактный с выводом в конце):
int[] array = FillArray();                                      // запускаем сбор массива через метод  
int result = NotEvenI(array);                                   // запускаем метод для проверки не четности индекса массива 
Console.Write($"[{string.Join(", ", array)}] -> {result}");     // выводим на печать результат

int[] FillArray()                            // создаем метод FillArray для создания рандом массива
{
    Random rnd = new Random();               // сокращение до rnd
    int[] arr = new int[rnd.Next(4, 10)];
    for (int i = 0; i < arr.Length; i++)     // пока index меньше чем length будем делать ->
    {
        arr[i] = rnd.Next(1, 100);           // cобираем массив из цифр от 1 до 100
    }
    return arr;                              // выводим полученный массив
}

int NotEvenI(int[] arr)                        // создаем метод для проверки не четности индекса массива
{
    int sum = 0;                               // создаем переменную sum со стартовым значением 0
    for (int i = 0; i < arr.Length; i++)       // пока i меньше длинны полученного массива, то делаем ->
    {
        if (i % 2 != 0) sum = sum + arr[i];    // если выбранный индекс делится на 2 с остатком, то прибавляем к сумме символ под данным индексом
    }
    return sum;                                // выводим sum
}
