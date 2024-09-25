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

        [Fact]
        public void TestNoDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Act
            list.RemoveDuplicate();

            // Assert
            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null";
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                list.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal(expectedOutput, result);
            }
        }

        [Fact]
        public void TestRotateByZero()
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.RotateLeft(0);
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", list.ToString());
        }

        [Fact]
        public void TestRotateByMoreThanLength()
        {
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.RotateLeft(7); // k > length, 7 % 5 = 2
            Assert.Equal("Head -> 30 -> 40 -> 50 -> 10 -> 20 -> Null", list.ToString());
        }

        [Fact]
        public void TestNormalRotate()
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.RotateLeft(2);
            Assert.Equal("Head -> 3 -> 4 -> 5 -> 1 -> 2 -> Null", list.ToString());
        }
    }
}