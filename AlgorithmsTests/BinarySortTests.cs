using Algorithms;

namespace AlgorithmsTests
{
    public class BinarySearchTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SearchValidNumberTest()
        {
            int[] array = new int[100];
            FillArray(array);

            int index = BinarySearcher.Search(array, 56);
            int result = array[index];
            int expected = 56;

            Assert.IsTrue(result == expected);
        }

        [Test]
        public void SearchNotValidNumberTest()
        {
            int[] array = new int[100];
            FillArray(array);

            Assert.IsTrue(BinarySearcher.Search(array, 556) == -1);
        }

        [Test]
        public void RecursiveSearchValidNumberTest()
        {
            int[] array = new int[100];
            FillArray(array);

            int index = BinarySearcher.RecursiveSearch(array, 56);
            int result = array[index];
            int expected = 56;

            Assert.IsTrue(result == expected);
        }

        [Test]
        public void RecursiveSearchNotValidNumberTest()
        {
            int[] array = new int[100];
            FillArray(array);

            Assert.IsTrue(BinarySearcher.RecursiveSearch(array, 556) == -1);
        }

        private static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
        }
    }
}