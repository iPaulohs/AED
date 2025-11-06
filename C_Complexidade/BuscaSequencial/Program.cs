// =================================================================================
// Dado um array de entrada e um elemento E, retorne a posição do elemento no array.
// Se ele não existir, retorne -1.
// =================================================================================


int[] nums = [1, 12, 56, 78, 23, 45, 90, 101];

static int BuscaSequencial(int[] nums, int pos)
{
    foreach(int i in nums)
    {
        if (i == pos) return i; 
    }

    return -1;
}

Console.WriteLine(BuscaSequencial(nums, 45));
Console.WriteLine(BuscaSequencial(nums, 18));
Console.WriteLine(BuscaSequencial(nums, 77));


// Complexidade de espaço: O(1) em todos os casos. A memória utilizada é equivalente ao tamanho da entrada.
// Complexidade de tempo: Melhor caso: Ω(1), Caso médio: Θ(n), Pior caso: O(n)