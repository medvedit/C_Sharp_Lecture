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
Console.WriteLine();

//Задача №2 Сумма чисел от 1 до n
// вариант с циклом for
int SumFor(int N)
{
    int result = 0;
    for (int i = 1; i <= N; i++)
    {
        result += i;
    }
    return result;
}
Console.WriteLine(SumFor(10)); // 55
Console.WriteLine();
// решение через рекурсию
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(15)); // 120
Console.WriteLine();

// Задача№3 Три шпиля и count количетво блинов. Башенка.http://rebus1.com/index.php?item=tower
void Towers(string with = "1", string on = "3", string some = "2", int count = 6)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();
Console.WriteLine();
