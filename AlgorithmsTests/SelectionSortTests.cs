using Algorithms;

namespace AlgorithmsTests;

public class SelectionSortTests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void SortToMoreTest()
    {
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
            52,
            25,
            85,
            65,
            12,
            94,
            473,
            523
        };

        SelectionSort.SortToMore(array);

        for (int i = 0; i < array.Length - 1; i++) 
            Assert.IsTrue(array[i] < array[i + 1]);
    }

    [Test]
    public void SortToMoreWithRandomNumbersTest()
    {
        int[] array = new int[10000];

        FillArrayWithRandomNumbers(array);

        SelectionSort.SortToMore(array);

        for (int i = 0; i < array.Length - 1; i++)
            Assert.IsTrue(array[i] < array[i + 1]);
    }

    private void FillArrayWithRandomNumbers(int[] array)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++) 
            array[i] = random.Next(0, int.MaxValue);
    }

    [Test]
    public void SortToLessTest()
    {
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
            52,
            25,
            85,
            65,
            12,
            94,
            473,
            523
        };

        SelectionSort.SortToLess(array);

        for (int i = 0; i < array.Length - 1; i++)
            Assert.IsTrue(array[i] > array[i + 1]);
    }
}