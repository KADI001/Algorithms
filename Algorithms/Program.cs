using System.Reflection;

Dictionary<int, int[]?> graph = new Dictionary<int, int[]?>()
{
    {1, new []{2, 14, 15, 16, 17, 18, 19, 20}},
    {2, new []{3}},
    {3, new []{4}},
    {4, new []{5}},
    {5, new []{6}},
    {6, new []{7}},
    {7, new []{8}},
    {8, new []{9}},
    {9, new []{10}},
    {10, new []{11}},
    {11, new []{12}},
    {12, new []{13}},
    {13, null},
    {14, new []{3}},
    {15, new []{5}},
    {16, new []{5}},
    {17, new []{8}},
    {18, new []{8}},
    {19, new []{8}},
    {20, new []{10}},
};

List<(int, int, int)> weight = new List<(int, int, int)>()
{
    (1, 2, -6),
    (1, 14, -2),
    (1, 15, -4),
    (1, 16, -3),
    (1, 17, -4),
    (1, 18, -3),
    (1, 19, -2),
    (1, 20, -3),
    (2, 3, -15),
    (3, 4, -4),
    (4, 5, -1),
    (5, 6, -2),
    (6, 7, -1),
    (7, 8, -4),
    (8, 9, -1),
    (9, 10, -1),
    (10, 11, -3),
    (11, 12, -1),
    (12, 13, 0),
    (14, 3, -15),
    (15, 5, -1),
    (16, 5, -1),
    (17, 3, -4),
    (18, 3, -4),
    (19, 3, -4),
    (20, 10, -1),
};

Dijkstra.Find(graph, weight, 1);
int b = 2;

#region Search

#endregion

#region Sort

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