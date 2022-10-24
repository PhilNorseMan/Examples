int[] arr = { 1, 2, 3, 4, 5, 6, 7, 1, 1 };

void PrintArray(int[] arr) // один из способов вывода массива в консоль методом
{
    int count = arr.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] arr) //Сортировка элеменотв массива (метод)
{
    for(int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i; //Присваиваем минимальную позицию как текущую позиция

        for(int j = i + 1; j < arr.Length; j++) // Присваиваем шаг в виде джи (выше минимальная позиция выведена как стартовая и)
        {
            if(arr[j] < arr[minPosition]) minPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
        // Идет свап значений между собой с использованием временной переменной
    }
}


PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);