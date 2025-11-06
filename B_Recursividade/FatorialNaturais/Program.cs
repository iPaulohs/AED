// ====================================F083=========================================
// Dado um número natural N, faça uma função que retorne o fatorial de N
// =================================================================================

//Imperativo

using System.Numerics;

static BigInteger FatorialImperativo(int num)
{
    if (num == 0) return 1;

    long total = 1;
    for (int i = 1; i <= num; i++)
    {
        total *= i;
    }
    return total;
}

Console.WriteLine(FatorialImperativo(15));

static BigInteger FatorialRecursivo(int num)
{
    if (num == 0) return 1;
    return num * FatorialRecursivo(num - 1);
}

Console.WriteLine(FatorialRecursivo(15));
