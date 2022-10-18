public class Dijkstra
{
    public static int Find(Dictionary<int, int[]?> graph, List<(int, int, int)> weight, int startPoint)
    {
        int[] pred = new int[graph.Keys.Count + 1];
        int[] shortest = new int[graph.Keys.Count + 1];
        int[] points = graph.Keys.ToArray();
        int exitPoint = -1;

        for (int i = 0; i < pred.Length; i++)
            pred[i] = -1;

        for (int i = 0; i < shortest.Length; i++)
            shortest[i] = int.MaxValue;

        pred[startPoint] = -1;
        shortest[startPoint] = 0;

        List<int> q = new List<int>();

        for (int i = 0; i < points.Length; i++) 
            q.Add(points[i]);

        for (int i = 0; i < weight.Count; i++)
        {
            if (weight[i].Item3 == 0)
                exitPoint = weight[i].Item2;
        }

        while (q.Count > 0)
        {
            int[] shortest2 = new int[q.Count];

            for (int i = 0; i < shortest2.Length; i++)
            {
                shortest2[i] = shortest[q[i]];
            }

            int min = shortest2.Min();

            for (int i = 0; i < q.Count; i++)
            {
                if (shortest[q[i]] == min)
                {
                    int u = q[i] - 1;
                    
                    for (int v = 0; v < points.Length; v++)
                    {
                        if (points[u] == points[v])
                            continue;

                        if (Weight(points[u], points[v]) != null)
                        {
                            Relax(points[u], points[v]);
                        }
                    }

                    q.Remove(q[i]);
                }
            }
        }

        void Relax(int u, int v)
        {
            int? weightUV = Weight(u, v);

            if (weightUV == null)
                throw new InvalidOperationException("There is no weight of u and v points");

            if (shortest[u] + weightUV.Value < shortest[v])
            {
                shortest[v] = shortest[u] + weightUV.Value;
                pred[v] = u;
            }
        }
        int? Weight(int u, int v)
        {
            int? w = null;

            for (int i = 0; i < weight.Count; i++)
            {
                if (weight[i].Item1 == u && weight[i].Item2 == v)
                {
                    w = weight[i].Item3;
                    break;
                }
            }

            return w;
        }

        return shortest[exitPoint];
    }
}