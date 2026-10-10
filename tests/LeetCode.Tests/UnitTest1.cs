using Xunit;
using LeetCode.Solutions.Problems.P1_100;

namespace LeetCode.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("babad", "bab")]     // “bab” 或 “aba” 都可以
        [InlineData("cbbd", "bb")]       // 偶数回文
        [InlineData("a", "a")]           // 单字符
        [InlineData("ac", "a")]          // 无明显回文，返回第一个字符
        [InlineData("bb", "bb")]         // 简单偶数回文
        [InlineData("racecar", "racecar")] // 奇数回文
        [InlineData("abbcccbbbca", "bbcccbb")] // 较长回文
        public void TestLongestPalindrome(string input, string expected)
        {
            // Arrange
            var solution = new L5_LongestPalindromicSubstring();

            // Act
            string result = solution.LongestPalindrome(input);

            // Assert
            // 注意：对于像 "babad" 这样有多个解的情况（"bab" 或 "aba"），只要长度符合且确实是回文即可。
            // 如果只允许完全匹配特定字符串，用 Assert.Equal(expected, result)。
            Assert.Equal(expected.Length, result.Length);

            // 验证结果本身确实是回文
            Assert.Equal(result, new string(result.Reverse().ToArray()));
        }
    }
}