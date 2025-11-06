// ====================================F082=========================================
// Dado um número natural N, faça uma função que retorne a soma de todos os números de 0 até N
// =================================================================================

//Imperativo - Sem recursividade

static int SomaNaturaisImperativo(int num)
{
    int total = 0;

    for (int i = 0; i <= num; i++)
    {
        total += i;
    }

    return total;
}

Console.WriteLine(SomaNaturaisImperativo(5));


//Recursivo - Soma(n) = n + Soma(n - 1)

static int SomaNaturaisRecursivo(int num)
{
    if (num == 0) return 0;
    return num + SomaNaturaisRecursivo(num - 1);
}

Console.WriteLine(SomaNaturaisRecursivo(5));
