namespace Algorithms;

public class QuickSort
{
    public static void SortToMore(int[] array) => 
        Sort(array, 0, array.Length - 1, false);

    public static void SortToLess(int[] array) => 
        Sort(array, 0, array.Length - 1, true);

    private static void Sort(int[] array, int p, int q, bool toLess)
    {
        if (p >= q)
            return;

        int pivot = GetPivot(array, p, q);

        Sort(array, p, pivot - 1, toLess);
        Sort(array, pivot + 1, q, toLess);
    }

    private static int GetPivot(int[] array, int p, int q, bool toLess = false)
    {
        int pivot = p - 1;

        for (int i = p; i <= q; i++)
        {
            if (toLess == false)
            {
                if (array[i] < array[q])
                {
                    pivot++;
                    Swap(ref array, i, pivot);
                }
            }
            else
            {
                if (array[i] > array[q])
                {
                    pivot++;
                    Swap(ref array, i, pivot);
                }
            }
        }

        pivot++;
        Swap(ref array, pivot, q);

        return  pivot;
    }

    private static void Swap(ref int[] array, int p, int q)
    {
        int temp2 = array[p];
        array[p] = array[q];
        array[q] = temp2;
    }
}