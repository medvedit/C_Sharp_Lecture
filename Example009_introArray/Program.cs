int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//              0    1   2   3   4   5   6   7   8
int[] array = { 14, 22, 35, 469, 51, 61, 23, 18, 74 };

int result = Max(
            Max(array[0], array[1], array[2]),
            Max(array[3], array[4], array[5]),
            Max(array[6], array[7], array[8])
);
Console.WriteLine(result);
// Решение задачи нахождения максимального числа в массиве из девяти чисел.