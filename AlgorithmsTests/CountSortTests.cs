namespace AlgorithmsTests;

public class CountSortTests
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
        };

        array = CountSort.SortToMore(array, 9);

        for (int i = 0; i < array.Length - 1; i++)
            Assert.IsTrue(array[i] <= array[i + 1]);
    }

    [Test]
    public void SortToMoreWithRandomNumbersTest()
    {
        int[] randomArray = new int[10000];
        FillArrayWithRandomNumbers(randomArray, 9999);

        randomArray = CountSort.SortToMore(randomArray, 9999);

        for (int i = 0; i < randomArray.Length - 1; i++)
            Assert.IsTrue(randomArray[i] <= randomArray[i + 1]);
    }


    private static void FillArrayWithRandomNumbers(int[] array, int maxValue)
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(0, maxValue);
    }
}