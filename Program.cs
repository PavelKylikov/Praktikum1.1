// Метод наполнения массива случайными (Fill) числами от [1 до 10).
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// Метод вывода (Print) в консоль массива.
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
         Console.Write(col[position] + " ");
         position++;
    }
}

// Команда: Создай новый массив array в котором будет 10 элементов 
int[] array1 = new int[10];
// Заполняем массив array случайными числами.
FillArray(array1);
// Выводим массив array в консоль.
PrintArray(array1);
Console.WriteLine();
// Определяем количество чётных элементов в массиве
int honest = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] % 2 == 0)
    {
        honest = honest + 1;
    }
}
Console.WriteLine(honest);
// Создаём массив с длинной равному колличеству 
// чётных элементов в изначальном массиве
int [] array2 = new int [honest];
// Заполняем новый массив чётными элементами из изначального массива
int j = 0;
int q = 0;
while (j < array1.Length)
{
    if (array1[j] % 2 == 0)
    {
        array2[q] = array1[j];
        j++;
        q++;
    }
    else
    {
        j++;
    }
}
PrintArray(array2);