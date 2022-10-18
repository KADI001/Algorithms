using Algorithms;

namespace AlgorithmsTests;

public class TopologicalSortTests
{

    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void SortTest()
    {
        Dictionary<int, int[]?> graph = new Dictionary<int, int[]?>()
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

        int[] expected = new int[]
        {
            1,
            2,
            9,
            3,
            10,
            4,
            5,
            6,
            7,
            11,
            8,
            12,
            13,
            14
        };

        int[] result = TopologicalSort.Sort(graph);

        for (int i = 0; i < expected.Length; i++)
        {
            Assert.IsTrue(expected[i] == result[i]);
        }
    }
}