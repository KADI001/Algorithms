namespace Algorithms;

public class TopologicalSort
{
    public static int[] Sort(Dictionary<int, int[]?> graph)
    {
        Queue<int> next = new Queue<int>();
        int[] numberPointEnters = new int[graph.Keys.Count];
        int[] points = graph.Keys.ToArray();

        for (int i = 0; i < graph.Keys.Count; i++)
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