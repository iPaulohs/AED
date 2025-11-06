// ===============================F074========================================
// Dados dois arrays de mesmo tamanho, calcule o produto escalar.
// numsOne = [1, 2], numsTwo = [3, 4] // (1 * 3) + (2 * 4) = 11
// =======================================================================

int[] numsOne = [1, 2];
int[] numsTwo = [3, 4];

static int ProdutoEscalarDoisArrays(int[] numsOne, int[] numsTwo)
{
    if (numsOne.Length != numsTwo.Length)
    {
        throw new ArgumentException("Arrays devem ter o mesmo tamanho.");
    }

    int total = 0;

    for (var i = 0; i < numsOne.Length; i++)
    {
        total += numsOne[i] * numsTwo[i];
    }

    return total;
}

Console.WriteLine(ProdutoEscalarDoisArrays(numsOne, numsTwo));