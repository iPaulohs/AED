// ================================F093 - Reverse===================================
// Dado um conjunto nums, faça uma função que retorne o conjunto em ordem reversa ao da entrada
// [1, 2, 3, 4] => [4, 3, 2, 1]
// =================================================================================

using System.Diagnostics;

int[] nums = [.. Enumerable.Range(1, 25)];
string[] nums2 = ["Um", "Dois", "Tres", "Quatro"];
var sw = new Stopwatch();

static T[] ReverseArray<T>(T[] list, in Stopwatch sw)
{
    if (list.Length <= 1) return list;

    sw.Start();
    T[] result = new T[list.Length];

    for (int i = 0; i < list.Length; i++)
    {
        result[i] = list[list.Length - 1 - i];
    }
    sw.Stop();

    Console.WriteLine($"Tempo gasto: {sw.Elapsed}");
    return result;
}

static T[] ReverseArrayRecursive<T>(T[] list)
{
    if (list.Length <= 1) return list;
    var head = list[0];

    var tail = list.Skip(1).ToArray();

    var result = ReverseArrayRecursive(tail).Append(head).ToArray();

    result.WriteValues();

    return result;
}

ReverseArrayRecursive(nums).WriteValues();


public static class ArrExtensions
{
    public static void WriteValues<T>(this T[] arr)
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
