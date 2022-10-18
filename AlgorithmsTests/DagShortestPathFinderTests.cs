namespace AlgorithmsTests;

public class DagShortestPathFinderTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void FindDagShortestPathTest()
    {
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

        int expected = -39;
        int actual = DagShortestPathFinder.FindDagShortestPath(graph, weight, 1);

        Assert.AreEqual(expected, actual);
    }
}