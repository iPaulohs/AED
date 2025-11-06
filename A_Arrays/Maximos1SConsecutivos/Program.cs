// ===============================F073============================================
// Dado um numsay binário (0s e 1s) nums, retorne a quantidade máxima de 1s consecutivos.
// nums = [0, 0, 0, 1, 1, 1] //3
// ===============================================================================

int[] nums = [0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0];

static int MaximoUnsConsecutivos(int[] nums)
{
    int quantidade = 0;
    int maximo = 0;

    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1 && nums[i] == 0)
        {
            throw new ArgumentException("numsay deve ser binário.", nameof(nums));
        }

        if (nums[i] == 1)
        {
            quantidade++;
        }
        else
        {
            if (quantidade > maximo)
            {
                maximo = quantidade;
            }

            quantidade = 0;
        }
    }

    return maximo;
}

Console.WriteLine(MaximoUnsConsecutivos(nums));
