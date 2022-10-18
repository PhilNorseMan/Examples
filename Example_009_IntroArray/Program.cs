int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//   индекс      0    1   2   3   4   5   6   7  8
int[] array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };  // Запись массива с именем array

array[0] = 12; // Присвоение значения элементу массива с инд 0.

int max = Max( //Для наглядности функций записано с переносом строк, но по-факту можно и в одну строку писать
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
    );

Console.WriteLine(max);

// Данный код работает только для конкртеного кол-ва чисел.