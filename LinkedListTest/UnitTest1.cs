using System;
using Xunit;
using challenges_and_data_structures.Data_Structures.LinkedList;

namespace LinkedListTest
{
    public class LinkedListTests
    {
        [Fact]
        public void TestRemoveNodeFromEnd()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Act
            list.Remove(30);

            // Assert
            Assert.False(list.Includes(30));
        }

        [Fact]
        public void TestPrintList()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null";

            // Act and Assert
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                list.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal(expectedOutput, result);
            }
        }
    }
}