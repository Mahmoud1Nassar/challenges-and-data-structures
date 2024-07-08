using challenges_and_data_structures.Challenges.Reverse_Words;
namespace RevrseWords
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseWords_ShouldReverseWordsInString()
        {
            // Test case 1
            string input1 = "csharp is programming language";
            string expectedOutput1 = "language programming is csharp";
            string result1 = ReverseWord.ReverseWords(input1);
            Assert.Equal(expectedOutput1, result1);

            // Test case 2
            string input2 = "Reverse the words in this sentence";
            string expectedOutput2 = "sentence this in words the Reverse";
            string result2 = ReverseWord.ReverseWords(input2);
            Assert.Equal(expectedOutput2, result2);

            // Test case 3
            string input3 = "challenges and data structures";
            string expectedOutput3 = "structures data and challenges";
            string result3 = ReverseWord.ReverseWords(input3);
            Assert.Equal(expectedOutput3, result3);
        }
    }
}