// Рекурсивная функция - это функция вызвающяя сама себя.

// Задача №1: Собрать строку с числами от a до b, a ≤ b .
// Вариант с циклом for
string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result = result + $"{i} ";
    }
    return result;
}
Console.WriteLine(NumberFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine();
// Вариант через рекурсию
string NumberRec(int a, int b)
{
    if (a <= b) return NumberRec(a + 1, b) + $"{a}";
    else return String.Empty;
}
Console.WriteLine(NumberFor(1, 20)); // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20