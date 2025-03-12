// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! - commit 1");
Console.WriteLine("Hello, World! - commit 2");
Console.WriteLine("Hello, World! - ostatni commit");
Console.Write("Enter the Fibonacci index (N): ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine($"The {n}-th Fibonacci number is: {CalculateFibonacci(n)}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}

static int CalculateFibonacci(int n)
{
    if (n <= 0) return 0;
    if (n == 1) return 1;

    int a = 0, b = 1, result = 0;
    for (int i = 2; i <= n; i++)
    {
        result = a + b;
        a = b;
        b = result;
    }
    return result;
}
