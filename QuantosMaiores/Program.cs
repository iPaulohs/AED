// ====================================================================================
// Dado um vetor de entrada, retorne outro vetor que indica quantos números existem 
// maiores que cada um no vetor. Algoritmo de órdem quadrática.
// ====================================================================================

static int[] QuantosNumerosMaiores(int[] nums)
{
    int[] qtdMaiores = new int[nums.Length];

    for(int i = 0; i < nums.Length; i++) //N
    {
        for (int j = 0; j < nums.Length; j++) //N²
        {
            if (nums[j] > nums[i])
            {
                qtdMaiores[i]++;
            }
        }
    }

    return qtdMaiores;
}

var result = QuantosNumerosMaiores([7, 3, 8, 7, 5]);

foreach(var r in result)
{
    Console.WriteLine(r);
}