// Фибоначчи это:
// f(1) = 1
// f(2) = 1
// f(3) = 2
// f(4) = 3
// f(5) = 5
// f(6) = 8
// ...
// f(n) = f(n - 1) + f(n - 2)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 50; i++)
// {
//     Console.WriteLine($" {i}  {Fibonacci(i)}");
// }
//  1  1    Ответ:
//  2  1
//  3  2
//  4  3
//  5  5
//  6  8
//  7  13
//  8  21
//  9  34
//  10  55
//  11  89
//  12  144
//  13  233
//  14  377
//  15  610
//  16  987
//  17  1597
//  18  2584
//  19  4181
//  20  6765
//  21  10946
//  22  17711
//  23  28657
//  24  46368
//  25  75025
//  26  121393
//  27  196418
//  28  317811
//  29  514229
//  30  832040
//  31  1346269
//  32  2178309
//  33  3524578
//  34  5702887
//  35  9227465
//  36  14930352
//  37  24157817  // заметно визуально падение скорости рачета.
//  38  39088169
//  39  63245986
//  40  102334155
//  41  165580141
//  42  267914296
//  43  433494437
//  44  701408733
//  45  1134903170
//  46  1836311903
//  47  2971215073
//  48  4807526976
//  49  7778742049

// Метод фибоначи по итеративному методу:

decimal fIte = 0;

decimal FibonacciIterration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
Console.WriteLine();
for (int n = 10; n <= 40; n++)
{
    Console.WriteLine($"FibonacciIterration({n}) = {FibonacciIterration(n)} fIte = {fIte}");
    fIte = 0;
}
// FibonacciIterration(10) = 89 fIte = 10
// FibonacciIterration(11) = 144 fIte = 11
// FibonacciIterration(12) = 233 fIte = 12
// FibonacciIterration(13) = 377 fIte = 13
// FibonacciIterration(14) = 610 fIte = 14
// FibonacciIterration(15) = 987 fIte = 15
// FibonacciIterration(16) = 1597 fIte = 16
// FibonacciIterration(17) = 2584 fIte = 17
// FibonacciIterration(18) = 4181 fIte = 18
// FibonacciIterration(19) = 6765 fIte = 19
// FibonacciIterration(20) = 10946 fIte = 20
// FibonacciIterration(21) = 17711 fIte = 21
// FibonacciIterration(22) = 28657 fIte = 22
// FibonacciIterration(23) = 46368 fIte = 23
// FibonacciIterration(24) = 75025 fIte = 24
// FibonacciIterration(25) = 121393 fIte = 25
// FibonacciIterration(26) = 196418 fIte = 26
// FibonacciIterration(27) = 317811 fIte = 27
// FibonacciIterration(28) = 514229 fIte = 28
// FibonacciIterration(29) = 832040 fIte = 29
// FibonacciIterration(30) = 1346269 fIte = 30
// FibonacciIterration(31) = 2178309 fIte = 31
// FibonacciIterration(32) = 3524578 fIte = 32
// FibonacciIterration(33) = 5702887 fIte = 33
// FibonacciIterration(34) = 9227465 fIte = 34
// FibonacciIterration(35) = 14930352 fIte = 35
// FibonacciIterration(36) = 24157817 fIte = 36
// FibonacciIterration(37) = 39088169 fIte = 37
// FibonacciIterration(38) = 63245986 fIte = 38
// FibonacciIterration(39) = 102334155 fIte = 39
// FibonacciIterration(40) = 165580141 fIte = 40