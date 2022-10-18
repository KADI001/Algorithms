namespace Algorithms;

public class InsertionSort
{
    public static void SortToMore(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = i;

            for (int j = key - 1; j >= 0; j--)
            {
                if (array[j] > array[key])
                {
                    int temp = array[key];
                    array[key] = array[j];
                    array[j] = temp;
                    key--;
                }
            }
        }
    }

    public static void SortToLess(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = i;

            for (int j = key - 1; j >= 0; j--)
            {
                if (array[j] < array[key])
                {
                    int temp = array[key];
                    array[key] = array[j];
                    array[j] = temp;
                    key--;
                }
            }
        }
    }
}