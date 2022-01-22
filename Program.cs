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
int[] array = new int[10];
// Заполняем массив array случайными числами.
FillArray(array);
// Выводим массив array в консоль.
PrintArray(array);
Console.WriteLine();
//Определяем количество чётных элементов
int honest = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        honest = honest + 1;
    }
}
Console.WriteLine(honest);