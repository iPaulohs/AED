// =======================F084 - Recursividade de cauda=============================
// Dado um número natural N, faça uma função que retorne o fatorial de N 
// =================================================================================

static int FatorialRecursivoDeCauda(int num)
{
    return FatorialAuxiliar(num, 1);
}

static int FatorialAuxiliar(int num, int total)
{
    if (num == 0) return total;
    Console.WriteLine($"A: {num}, total: {total}");
    return FatorialAuxiliar(num - 1, num * total);
}

Console.WriteLine(FatorialRecursivoDeCauda(5));

static int FibonacciRecursivoDeCauda(int num)
{
    return FibonacciAuxiliar(num, 0, 1);
}

static int FibonacciAuxiliar(int num, int a, int b)
{
    if(num == 0) return a;
    if (num == 1) return b;

    Console.WriteLine($"A: {a}, B: {b}, num: {num}");

    return FibonacciAuxiliar(num - 1, b, a + b);
}

Console.WriteLine(FibonacciRecursivoDeCauda(10));

