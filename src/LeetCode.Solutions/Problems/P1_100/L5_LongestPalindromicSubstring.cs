using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Problems.P1_100
{
    public class L5_LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            int start = 0;
            int maxLength = 0;

            // 遍历字符串中的每一个位置作为中心
            for (int i = 0; i < s.Length; i++)
            {
                // 1. 奇数长度回文：以 s[i] 为中心，向左右扩展
                int left1 = i;
                int right1 = i;
                while (left1 >= 0 && right1 < s.Length && s[left1] == s[right1])
                {
                    left1--;
                    right1++;
                }
                // 回文长度为 (right1 - 1) - (left1 + 1) + 1 = right1 - left1 - 1
                int len1 = right1 - left1 - 1;

                // 2. 偶数长度回文：以 s[i] 和 s[i+1] 为中心，向左右扩展
                int left2 = i;
                int right2 = i + 1;
                while (left2 >= 0 && right2 < s.Length && s[left2] == s[right2])
                {
                    left2--;
                    right2++;
                }
                int len2 = right2 - left2 - 1;

                // 取当前位置找到的最大回文长度
                int currentMax = Math.Max(len1, len2);

                // 如果比之前记录的最大长度还长，就更新结果
                if (currentMax > maxLength)
                {
                    maxLength = currentMax;
                    start = i - (maxLength - 1) / 2;
                }
            }

            return s.Substring(start, maxLength);
        }
    }
}