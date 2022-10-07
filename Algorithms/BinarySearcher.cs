namespace Algorithms;

public class BinarySearcher
{
    public static int Search(int[] array, int target)
    {
        int p = 0, q = array.Length - 1;

        while (p <= q)
        {
            int currentIndex = (p + q) / 2;

            if (array[currentIndex] == target)
                return currentIndex;

            if (array[currentIndex] > target)
            {
                q = currentIndex - 1;
            }

            if (array[currentIndex] < target)
            {
                p = currentIndex + 1;
            }
        }

        return -1;
    }

    public static int RecursiveSearch(int[] array, int target) => 
        RecursiveSearch(array, target, 0, array.Length - 1);

    private static int RecursiveSearch(int[] array, int target, int p, int q)
    {
        int r = (p + q) / 2;

        if (p > q)
            return -1;

        if (array[r] == target)
            return r;

        if (array[r] > target) 
            r = RecursiveSearch(array, target, p,r - 1);

        if (array[r] < target) 
            r = RecursiveSearch(array, target, r + 1, q);

        return r;
    }
}