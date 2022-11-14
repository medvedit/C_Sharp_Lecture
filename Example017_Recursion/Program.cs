// // Рекурсивная функция - это функция вызвающяя сама себя.

// // Задача №1: Собрать строку с числами от a до b, a ≤ b .
// // Вариант с циклом for
// string NumberFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result = result + $"{i} ";
//     }
//     return result;
// }
// Console.WriteLine(NumberFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
// Console.WriteLine();

// // Вариант через рекурсию
// string NumberRec(int a, int b)
// {
//     if (a <= b) return NumberRec(a + 1, b) + $"{a}";
//     else return String.Empty;
// }
// Console.WriteLine(NumberFor(1, 20)); // 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20
// Console.WriteLine();

// //Задача №2 Сумма чисел от 1 до n
// // вариант с циклом for
// int SumFor(int N)
// {
//     int result = 0;
//     for (int i = 1; i <= N; i++)
//     {
//         result += i;
//     }
//     return result;
// }
// Console.WriteLine(SumFor(10)); // 55
// Console.WriteLine();
// // решение через рекурсию
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(15)); // 120
// Console.WriteLine();

// // Задача№3 Три шпиля и count количетво блинов. Башенка.http://rebus1.com/index.php?item=tower
// void Towers(string with = "1", string on = "3", string some = "2", int count = 6)
// {
//     if (count > 1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1) Towers(some, on, with, count - 1);
// }
// Towers();
// Console.WriteLine();

// // Программа вывода рандомных чисел в консоль, в рандомных местах консоли
// Random r = new Random();
// Console.CursorVisible = false;
// while (true)
// {
//     Console.SetCursorPosition(
//         left: r.Next(Console.WindowWidth),
//         top: r.Next(Console.WindowHeight)
//         );
//     Console.Write(r.Next(10));
//     Thread.Sleep(1000);
// }
// // ctrl + C - остановка зацыкленного кода.


// Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Clear();
Console.WriteLine($"Дополнительная задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.");

int n = InputNumbers("Введите количество строк: ");

double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

FillPascalTriangle(pascalTriangle);

Console.WriteLine();
WriteArray(pascalTriangle);

TransformationPascalTriangle(pascalTriangle);

Console.WriteLine();
WriteArray(pascalTriangle);

void TransformationPascalTriangle(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}

void FillPascalTriangle(double[,] pascalTriangle)
{
  for (int k = 0; k < pascalTriangle.GetLength(0); k++)
  {
    pascalTriangle[k, 0] = 1;
  }
  for (int i = 1; i < pascalTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
    }
  }
}

void WriteArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}