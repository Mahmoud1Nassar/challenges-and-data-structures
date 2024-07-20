using challenges_and_data_structures.Data_Structures.LinkedList;
namespace MergeSortedLinkedListsTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMergingWhenOneListIsEmpty()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Add(1);
            list2.Add(3);
            list2.Add(5);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            string expectedOutput = "Head -> 1 -> 3 -> 5 -> Null";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                mergedList.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void TestMergingWhenBothListsAreEmpty()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            string expectedOutput = "Head -> Null";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                mergedList.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void TestMergingExampleLists()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            string expectedOutput = "Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                mergedList.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}