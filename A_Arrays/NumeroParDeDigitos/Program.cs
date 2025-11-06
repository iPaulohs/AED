// ===============================F075========================================
// Dados um array num, retorne quantos deles possuem um número par de dígitos.
// nums = [12, 123, 4589, 1] // 2 (12 e 4589)
// ===========================================================================

int[] nums = [12, 4567, 123, 19450, 132, 459332];

static int NumeroParDeDigitos(int[] nums)
{
    int total = 0;

    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i].ToString().Length % 2 == 0)
        {
            total++;
        }
    }
    return total;
}

Console.WriteLine(NumeroParDeDigitos(nums));