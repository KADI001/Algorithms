Dictionary<int, int[]?> edges = new Dictionary<int, int[]?>()
{
    {1, new int[]{3}},
    {2, new int[]{4}},
    {3, new int[]{4, 5}},
    {4, new int[]{6}},
    {5, new int[]{6}},
    {6, new int[]{7, 11}},
    {7, new int[]{8}},
    {8, new int[]{13}},
    {9, new int[]{10}},
    {10, new int[]{11}},
    {11, new int[]{12}},
    {12, new int[]{13}},
    {13, new int[]{14}},
    {14, null},
};

var sort = new TopologicalSort().Sort(edges);
int a = 0;

#region Search

#endregion

#region Sort

public class TopologicalSort
{
    public int[] Sort(Dictionary<int, int[]?> graph)
    {
        Queue<int> next = new Queue<int>();
        int[] numberPointEnters = new int[graph.Keys.Count];
        int[] points = graph.Keys.ToArray();

        for (int i = 0; i < numberPointEnters.Length; i++)
        {
            int number = 0;

            for (int j = 1; j <= graph.Keys.Count; j++)
            {
                if(i + 1 == j || graph[j] == null)
                    continue;

                for (int k = 0; k < graph[j].Length; k++)
                {
                    if (graph[j][k] == points[i])
                        number++;
                }
            }

            numberPointEnters[i] = number;
        }

        int weightS = graph.Keys.Count;

        int[] result = new int[weightS];

        for (int q = 0; q < weightS; q++)
        {
            for (int i = 0; i < graph.Keys.Count; i++)
            {
                if (numberPointEnters[i] == -1 || next.Contains(i + 1))
                    continue;

                if (numberPointEnters[i] == 0)
                    next.Enqueue(i + 1);
            }

            int point = next.Peek();
            result[q] = point;
            numberPointEnters[point - 1]--;

            if (graph[point] != null)
            {
                for (int j = 0; j < graph[point].Length; j++)
                {
                    int nextPoint = graph[point][j];
                    numberPointEnters[nextPoint - 1]--;
                }

                next.Dequeue();
            }
        }

        return result;
    }
}

/*
public class BitwiseSort
{
    private static Dictionary<char, int> charToInt = new Dictionary<char, int>()
    {
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9}, 
        {'A', 10},
        {'B', 11},
        {'C', 12},
        {'D', 13},
        {'E', 14},
        {'F', 15},
        {'G', 16},
        {'I', 18},
        {'H', 17},
        {'J', 19},
        {'K', 20},
        {'L', 21},
        {'M', 22},
        {'N', 23},
        {'O', 24},
        {'P', 25},
        {'Q', 26},
        {'R', 27},
        {'S', 28},
        {'T', 29},
        {'U', 30},
        {'V', 31},
        {'W', 32},
        {'X', 33},
        {'Y', 34},
        {'Z', 35},
    };
    private static Dictionary<int, char> intToChar = new Dictionary<int, char>()
    {
        {0, '0'},
        {1, '1'},
        {2, '2'},
        {3, '3'},
        {4, '4'},
        {5, '5'},
        {6, '6'},
        {7, '7'},
        {8, '8'},
        {9, '9'},
        {10, 'A'},
        {11, 'B'},
        {12, 'C'},
        {13, 'D'},
        {14, 'E'},
        {15, 'F'},
        {16, 'G'},
        {18, 'I'},
        {17, 'H'},
        {19, 'J'},
        {20, 'K'},
        {21, 'L'},
        {22, 'M'},
        {23, 'N'},
        {24, 'O'},
        {25, 'P'},
        {26, 'Q'},
        {27, 'R'},
        {28, 'S'},
        {29, 'T'},
        {30, 'U'},
        {31, 'V'},
        {32, 'W'},
        {33, 'X'},
        {34, 'Y'},
        {35, 'Z'},
    };

    public static void Sort(string[] array, int stringLength)
    {
        int[,] arrayAsInt = new int[array.Length, stringLength];

        for (int i = 0; i < stringLength; i++)
        {
            for (int a = 0; a < array.Length; a++)
            {
                for (int j = 0; j < stringLength; j++)
                {
                    arrayAsInt[a,j] = charToInt[array[a][j]];
                }
            }

            int length = stringLength - i;

            int[] sortNumber = new int[array.Length];

            Dictionary<int, int[]> sortMap = new Dictionary<int, int[]>();

            for (int j = 0; j < array.Length; j++)
            {
                sortNumber[j] = arrayAsInt[j, length - 1];
            }

            for (int j = 0; j < array.Length; j++)
            {
                int[,] compParts = new int[array.Length, length - 1];

                for (int k = 0; k < compParts.Length; k++)
                {
                    for (int l = 0; l < length - 1; l++)
                    {
                        compParts[k, l] = arrayAsInt[j, k];
                    }

                    
                }

                //TODO:
            }

            sortNumber = CountSort.SortToMore(sortNumber, 35);

            for (int j = 0; j < array.Length; j++)
            {
                string f = "";
                string s = "";
                string r = "";

                f = intToChar[sortNumber[0]].ToString();

                for (int k = 0; k < length; k++)
                {
                    s += intToChar[sortMap[sortNumber[j]][k]].ToString();
                }

                r = f + s;
                array[j] = r;
            }

            
        }
    }

    private static int[] Invert(int[] array)
    {
        for (int i = 0, k = array.Length - 1; i < array.Length && k >= 0; i++, k++)
        {
            int temp = array[i];
            array[i] = array[k];
            array[k] = temp;
        }

        return array;
    }
}
*/

#endregion