using Algorithms;

public class DagShortestPathFinder
{
    public static int FindDagShortestPath(Dictionary<int, int[]?> graph, List<(int, int, int)> weight, int startPoint)
    {
        int[] pred = new int[graph.Keys.Count + 1];
        int[] shortest = new int[graph.Keys.Count + 1];
        int[] points = graph.Keys.ToArray();

        for (int i = 0; i < pred.Length; i++) 
            pred[i] = -1;

        for (int i = 0; i < shortest.Length; i++) 
            shortest[i] = int.MaxValue;

        pred[startPoint] = -1;
        shortest[startPoint] = 0;

        int[] linearGraph = TopologicalSort.Sort(graph);

        for (int i = 0; i < linearGraph.Length; i++)
        {
            for (int j = 0; j < points.Length; j++)
            {
                if(linearGraph[i] == points[j])
                    continue;

                if (Weight(linearGraph[i], points[j]) != null)
                {
                    Relax(linearGraph[i], points[j]);
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
        
        return shortest[linearGraph[linearGraph.Length - 1]];
    }
}