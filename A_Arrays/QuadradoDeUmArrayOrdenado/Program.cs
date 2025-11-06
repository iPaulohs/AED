// ===============================F077=======================================
// Dado um array nums de números ordenados em ordem crescente, retorne um array com os 
// quadrados de cada numero. também ordenado de forma crescente.
// ==========================================================================

int[] nums = [-2, 12, -5, 8, 3, 15, 27];

static int[] QuadradosDeArrayOrdenado(int[] nums)
{
    int[] quadradoNums = new int[nums.Length];
    int index = 0;

    foreach (var n in nums)
    {
        quadradoNums[index] = n * n;
        index++;
    }

    Array.Sort(quadradoNums);

    return quadradoNums;
}

QuadradosDeArrayOrdenado(nums).WriteValues();


public static class IntArrExtensions
{
    public static void WriteValues(this int[] arr)
    {
        Console.Write("[");
        for (var i = 0; i < arr.Length; i++)
        {
            if (i != (arr.Length - 1))
            {
                Console.Write($"{arr[i]}, ");
            }
            else
            {
                Console.Write(arr[i]);
            }

        }
        Console.Write("]");
        Console.WriteLine();
    }
}





