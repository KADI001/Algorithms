public class MergeSort
{
    public static int[] SortToMore(int[] array)
    {
        int p = 0, q = array.Length - 1;

        if(p >= q)
            return array;

        int ci = ((p + 1) + q) / 2;

        int[] array1 = new int[ci];
        int[] array2 = new int[array.Length - ci];

        for (int i = 0; i < ci; i++) 
            array1[i] = array[i];

        for (int i = 0; i <= q - ci; i++) 
            array2[i] = array[ci + i];

        return Merge(SortToMore(array1), SortToMore(array2));
    }

    public static int[] SortToLess(int[] array)
    {
        int p = 0, q = array.Length - 1;

        if (p >= q)
            return array;

        int ci = ((p + 1) + q) / 2;

        int[] array1 = new int[ci];
        int[] array2 = new int[array.Length - ci];

        for (int i = 0; i < ci; i++) 
            array1[i] = array[i];

        for (int i = 0; i <= q - ci; i++) 
            array2[i] = array[ci + i];

        return Merge(SortToLess(array1), SortToLess(array2), true);
    }

    public static int[] Merge(int[] left, int[] right, bool toLess = false)
    {
        int leftP = 0, rightP = 0;
        int mergedArrayLength = left.Length + right.Length;
        int[] array = new int[mergedArrayLength];

        for (int i = 0; i < mergedArrayLength; i++)
        {
            if (leftP < left.Length && rightP < right.Length)
            {
                if (toLess == false)
                {
                    if (left[leftP] < right[rightP])
                    {
                        array[i] = left[leftP];
                        leftP++;
                    }
                    else
                    {
                        array[i] = right[rightP];
                        rightP++;
                    }
                }
                else
                {
                    if (left[leftP] > right[rightP])
                    {
                        array[i] = left[leftP];
                        leftP++;
                    }
                    else
                    {
                        array[i] = right[rightP];
                        rightP++;
                    }
                }
                
            }
            else
            {
                if (rightP < right.Length)
                {
                    array[i] = right[rightP];
                    rightP++;
                }
                else
                {
                    array[i] = left[leftP];
                    leftP++;
                }
            }
        }

        return array;
    }
}