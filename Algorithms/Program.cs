
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.WebRequestMethods;

int[] array = new int[]
{
    2,
    9,
    6,
    7,
    3,
    5,
    4,
    8,
    1,
};
array = CountSort.SortToMore(array, 9);
  int a = 0;

#region Search

#endregion

#region Sort

/*
 * public class CountSort
{
    public static int[] SortToMore(int[] array, int arrayKeysRange)
    {
        int[] equal = CountKeysEqual(array, arrayKeysRange);
        int[] less = CountKeysLess(equal, arrayKeysRange);
        int[] next = new int[less.Length];
        int[] result = new int[array.Length];

        for (int i = 0; i < equal.Length; i++)
        {
            next[i] = less[i] + 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            int key = array[i];
            int index = next[key] - 1;
            result[index] = array[i];
            next[key]++;
        }

        return result;
    }

    private static int[] CountKeysEqual(int[] array, int arrayKeysRange)
    {
        int[] equal = new int[arrayKeysRange + 1];

        for (int i = 0; i < array.Length; i++)
        {
            equal[array[i]]++;
        }

        return equal;
    }

    private static int[] CountKeysLess(int[] equal, int equalKeysRange)
    {
        int[] less = new int[equal.Length];

        less[0] = equal[0];

        for (int i = 1; i < equal.Length; i++)
        {
            less[i] = less[i - 1] + equal[i - 1];
        }

        return less;
    }
}
 */

public class CountSort
{
    public static int[] SortToMore(int[] array, int arrayKeysRange)
    {
        int[] equal = CountKeysEqual(array, arrayKeysRange);
        int[] less = CountKeysLess(equal, arrayKeysRange);
        int[] next = new int[less.Length];
        int[] result = new int[array.Length];

        for (int i = 0; i < equal.Length; i++)
        {
            next[i] = less[i] + 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            int key = array[i];
            int index = next[key] - 1;
            result[index] = array[i];
            next[key]++;
        }

        return result;
    }

    private static int[] CountKeysEqual(int[] array, int arrayKeysRange)
    {
        int[] equal = new int[arrayKeysRange + 1];

        for (int i = 0; i < array.Length; i++)
        {
            equal[array[i]]++;
        }

        return equal;
    }

    private static int[] CountKeysLess(int[] equal, int equalKeysRange)
    {
        int[] less = new int[equal.Length];

        less[0] = 0;

        for (int i = 1; i < equal.Length; i++)
        {
            less[i] = less[i - 1] + equal[i - 1];
        }

        return less;
    }
}
#endregion