void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    { 
        Console.WriteLine(col[position]);
        position++;
    }  
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // При position =0, В случае отсутствия числа в массиве в отет приходит 0, и поэтому, по умолчании решили писать position = -1, что бы было понятно что искомого числа нет.
    while(index <count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;      // остановили поиск на первом (совпадении) найденном числе.
        }
        index++; 
    }
    return position;

}

int[] array = new int[10]; // new int[10] Создали новый массив в котором 10 элементов.

FillArray(array);
PrintArray(array);

Console.WriteLine();
int pos =IndexOf(array, 4);
Console.WriteLine(pos);
