using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Quick_View_Newspaper
{
    class HtmlRemoval
    {
        /// <summary>
        /// xóa thẻ trong chuỗi với lớp Regex.
        /// </summary>
        public static string StripTagsRegex(string source)
        {
            return Regex.Replace(source, "<.*?>", string.Empty);
        }

        /// <summary>
        /// Biên dịch xong rồi mới thực hiện.
        /// </summary>
        static Regex htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);

        /// <summary>
        /// Xóa thẻ html trong chuỗi với Regex biên dịch.
        /// </summary>
        public static string StripTagsRegexCompiled(string source)
        {
            return htmlRegex.Replace(source, string.Empty);
        }

        /// <summary>
        /// Xóa thẻ HTML trong chuỗi với mảng ký tự.
        /// </summary>
        public static string StripTagsCharArray(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
    }
}
