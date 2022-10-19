// Фибоначчи это:
// f(1) = 1
// f(2) = 1
// f(3) = 2
// f(4) = 3
// f(5) = 5
// f(6) = 8
// ...
// f(n) = f(n - 1) + f(n - 2)

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
 for (int i = 1; i < 50; i++)
 {
    Console.WriteLine($" {i}  {Fibonacci(i)}");
 }