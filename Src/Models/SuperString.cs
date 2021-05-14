using System;
using System.Collections.Generic;
using System.Text;

namespace Src.Models
{
    public static class SuperString
    {
        #region Snippet_PowerfulMethods

        /// <summary>Takes a string and change its order like a zig zag</summary>
        /// <params name="str">String to change</params>
        /// <params name="rows">Number of rows used to zig zag</params>
        /// <returns>A string with their elements in zig zag order</returns>
        public static string ConvertToZigZag(string str, int rows)
        {
            if (rows == 1) return str;

            var linesList = new List<StringBuilder>();

            for (int i = 0; i < Math.Min(rows, str.Length); i++)
            {
                linesList.Add(new StringBuilder());
            }

            var currentRow = 0;
            var goingDown = false;
            var linesArray = linesList.ToArray();

            foreach (var @char in str.ToCharArray())
            {
                linesArray[currentRow].Append(@char);

                if (currentRow == 0 || currentRow == rows - 1)
                {
                    goingDown = !goingDown;
                }

                currentRow += goingDown ? 1 : -1;
            }

            var retention = new StringBuilder();

            foreach (var line in linesList) retention.Append(line);

            return retention.ToString();
        }

        #endregion
    }
}