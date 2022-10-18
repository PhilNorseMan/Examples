void FillArray(int[] collection) //void - тип функции, означающий, что функция ничего не возвращает.
{
    int length = collection.Length; // задается переменная length, которая соответствует длине collection.
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //заполнение collection рандомными значениями пошагово в каждый индекс.
        index++; //index = index +1
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; // count идентичен length введен ради иного наименования переменной.
    int position = 0; //position идентичен index введен ради иного наименования перменной.
    while (position < count)
    {
        Console.WriteLine(col[position]); //Вывод в консоль пошагово элементов массива col пока position < cout (то есть пока индекс меньше длины массива)
        position++; //position = position + 1
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length; //присваиваем переменной count длину массива collection.
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);

array[4] = 4; // Принудительное добавление значений в индексы 4 и 6 значения 4.
array[6] = 4;

PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);